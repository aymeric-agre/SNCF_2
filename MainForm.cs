using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace SNCF_2
{
    public partial class MainForm : Form
    {
        string connString;
        MySqlConnection conn;
        MySqlCommand command;

        public MainForm()
        {
            connString = "Server=localhost;Port=3306;Database=sncf;Uid=root;password=root";
            conn = new MySqlConnection(connString);
            command = conn.CreateCommand();

            InitializeComponent();
        }

        private void createNewAccountButton_Click(object sender, EventArgs e)
        {
            string login = this.loginTextBox.Text.ToString();
            string password = this.passwordTextBox.Text.ToString();
            string name = this.nameTextBox.Text.ToString();
            string age = this.ageTextBox.Text.ToString();
            int ageValue;
            if (int.TryParse(age, out ageValue) && ageValue > 0 && ageValue < 150)
            {
                string reduction = Math.Abs((float)ageValue / 100f - 0.5).ToString().Replace(',','.');

                bool logged = loginFunction(login, password);

                if (!logged)
                {
                    conn.Open();
                    command.CommandText = "Insert into client (login, password, nom, age, reduction) values('" + login + "','" + password + "','" + name + "','" + age + "','" + reduction + "')";
                    command.ExecuteNonQuery();
                    conn.Close();
                    redirection();
                }
                else
                {
                    MessageBox.Show("Ce nom d'utilisateur existe déjà, veuillez en choisir un autre.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer votre âge réel.");
            }    
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = this.loginTextBox.Text.ToString();
            string password = this.passwordTextBox.Text.ToString();
            bool logged = loginFunction(login, password);
            if (!logged)
            {
                MessageBox.Show("Les informations de connexion sont inexactes.");
            }
            else
            {
                
            }
        }

        private bool loginFunction(string login, string password)
        {
            bool value;
            command.CommandText = "Select client.login from client where (login='" + login + "') AND (password='" + password + "')";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            MySqlDataReader reader = command.ExecuteReader();
            if (!reader.Read())
            {
                value = false;
            }
            else
            {
                value = true;
            }
            conn.Close();
            return value;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.createNewAccountButton.Visible = true;
            this.nameLabel.Visible = true;
            this.nameTextBox.Visible = true;
            this.ageLabel.Visible = true;
            this.ageTextBox.Visible = true;
        }

        private void redirection()
        {
            this.Hide();
            MyAccountForm myAccountForm = new MyAccountForm();
            myAccountForm.Show();
        }

    }
}
