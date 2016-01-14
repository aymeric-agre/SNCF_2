using System;
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
    public partial class MyAccountForm : Form
    {
        string connString;
        MySqlConnection conn;
        MySqlCommand command;
        client thisClient;
        bool modifying = false;
        bool allerRetour = false;

        public MyAccountForm(client loggedClient)
        {
            thisClient = loggedClient;
            connString = "Server=localhost;Port=3306;Database=sncf;Uid=root;password=root";
            conn = new MySqlConnection(connString);
            command = conn.CreateCommand();

            InitializeComponent();
        }

        private void myTicketsTabPage_Load(object sender, EventArgs e)
        {
            command.CommandText = "Select * from billet where (login='" + thisClient.login + "')";
            bool value;
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
        }

        private void myProfilTabPage_Load(object sender, EventArgs e)
        {
            command.CommandText = "Select * from billet where (login='" + thisClient.login + "')";
            
            bool value;
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
        }

        private void modifyProfilButton_Click(object sender, EventArgs e)
        {
            bool value;
            string textModifyProfilButton;
            if(modifying)
            {
                value = false;
                textModifyProfilButton = "Mettre à jour mon profil";
                modifying = false;
            }
            else
            {
                value = true;
                textModifyProfilButton = "Modifier mes informations";
                modifying = true;
            }
            this.passwordTextBox.ReadOnly = value;
            this.loginTextBox.ReadOnly = value;
            this.nomTextBox.ReadOnly = value;
            this.ageTextBox.ReadOnly = value;
            this.modifyProfilButton.Text = textModifyProfilButton;
        }

        private void MyAccountForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sncfDataSet.billet' table. You can move, or remove it, as needed.
            conn.Open();
            try
            {
                command.CommandText = "Select * from villes;";
                MySqlDataReader myReader;
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    string townName = myReader.GetString("nom");
                    selectionVilleDepartComboBox.Items.Add(townName);
                    SelectionVilleArriveeComboBox.Items.Add(townName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();

        }

        private void newTicketTabPage_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selectionVilleLabel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            allerRetour=!allerRetour;
            retourCalendar.Visible = !retourCalendar.Visible;
            RetourDateLabel.Visible = !RetourDateLabel.Visible;
        }
    }
}
