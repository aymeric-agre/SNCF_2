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
        MySqlConnection conn, conn2;
        MySqlCommand command, command2;

        public MainForm()
        {
            connString = "Server=localhost;Port=3306;Database=sncf;Uid=root;password=root";
            conn = new MySqlConnection(connString);
            conn2 = new MySqlConnection(connString);
            command = conn.CreateCommand();
            command2 = conn2.CreateCommand();

            InitializeComponent();
        }

        private void createNewAccountButton_Click(object sender, EventArgs e)
        {
            client thisClient = new client();
            thisClient.login = this.loginTextBox.Text.ToString();
            thisClient.password = this.passwordTextBox.Text.ToString();
            thisClient.nom = this.nameTextBox.Text.ToString();
            int ageValue;
            if (int.TryParse(this.ageTextBox.Text.ToString(), out ageValue) && ageValue > 0 && ageValue < 150)
            {
                thisClient.age = ageValue;
                thisClient.reduction = Math.Abs(ageValue / 100 - 0.5f);

                client logged = loginFunction(thisClient.login, thisClient.password);

                if (logged == null)
                {
                    try
                    {
                        conn.Open();
                        command.CommandText = "Insert into client (login, password, nom, age, reduction) values('" + thisClient.login + "','" + thisClient.password + "','" + thisClient.nom + "','" + thisClient.age + "','" + thisClient.reduction.ToString().Replace(",", ".") + "')";
                        command.ExecuteNonQuery();
                        command.CommandText = "Select * from client where (login='" + thisClient.login + "')";
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            thisClient.idclient = reader.GetInt32("idclient");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        redirection(thisClient);
                    }       
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
            client thisClient = loginFunction(login, password);
            if (thisClient == null)
            {
                MessageBox.Show("Les informations de connexion sont inexactes.");
            }
            else
            {
                redirection(thisClient);
            }
        }

        private client loginFunction(string login, string password)
        {
            client thisClient = new client();
            command.CommandText = "Select * from client where (login='" + login + "') AND (password='" + password + "')";
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
                conn.Close();
                return null;
            }
            else
            {
                thisClient.idclient = reader.GetInt32("idclient");
                thisClient.nom = reader.GetString("nom");
                thisClient.age = reader.GetInt32("age");
                thisClient.reduction = reader.GetFloat("reduction");
                thisClient.login = reader.GetString("login");
                thisClient.password = reader.GetString("password");                
                conn.Close();
                return thisClient;
            }
            
        }

        private void noAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.createNewAccountButton.Visible = true;
            this.nameLabel.Visible = true;
            this.nameTextBox.Visible = true;
            this.ageLabel.Visible = true;
            this.ageTextBox.Visible = true;
        }

        private void redirection(client thisClient)
        {
            MyAccountForm myAccountForm = new MyAccountForm(thisClient);
            myAccountForm.Show();
        }
    }
}
