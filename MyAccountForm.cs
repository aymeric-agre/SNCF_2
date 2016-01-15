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

        private DataGrid dg = null;
        private MySqlDataAdapter da = null;
        private DataSet ds = null;

        bool situationPlace = false; //fenêtre = true, couloir = false

        public MyAccountForm(client loggedClient)
        {
            thisClient = loggedClient;
            connString = "Server=localhost;Port=3306;Database=sncf;uid=root;password=root";
            conn = new MySqlConnection(connString);
            command = conn.CreateCommand();

            InitializeComponent();
        }

        private void myTicketsTabPage_Load(object sender, EventArgs e)
        {
            dg = new DataGrid();
            dg.CaptionBackColor = System.Drawing.Color.White;
            dg.CaptionForeColor = System.Drawing.Color.Black;
            dg.CaptionText = "Mes Billets";
            dg.Location = new Point(8, 0);
            dg.Size = new Size(350, 300);
            dg.TabIndex = 0;
            dg.Parent = this.myTicketsTabPage;  

            command.CommandText = "Select * from billet where (idclient='" + thisClient.idclient + "')";
            try
            {
                conn.Open();
                ds = new DataSet();
                da = new MySqlDataAdapter(command.CommandText, conn);
                da.Fill(ds, "Mes billets");

                dg.DataSource = ds.Tables["billet"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void myProfilTabPage_Load(object sender, EventArgs e)
        {
            this.loginTextBox.Text = thisClient.login;
            this.nomTextBox.Text = thisClient.nom;
            this.ageTextBox.Text = thisClient.age.ToString();
            this.passwordTextBox.Text = thisClient.password;
        }

        private void modifyProfilButton_Click(object sender, EventArgs e)
        {
            bool value;
            string textModifyProfilButton;

            if(!modifying)
            {
                thisClient.login = this.loginTextBox.Text;
                thisClient.password = this.passwordTextBox.Text;
                thisClient.nom = this.nomTextBox.Text;
                thisClient.age = int.Parse(this.ageTextBox.Text);
                value = false;
                textModifyProfilButton = "Mettre à jour mon profil";
                modifying = true;
                try
                {
                    conn.Open();
                    command.CommandText = "UPDATE client SET (login = '" + thisClient.login + "', password = '" + thisClient.password + "', age = '" + thisClient.age.ToString() +"', nom = '" + thisClient.nom + "')";
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }                
            }
            else
            {
                value = true;
                textModifyProfilButton = "Modifier mes informations";
                modifying = false;
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
            myProfilTabPage_Load(sender, e);
            myTicketsTabPage_Load(sender, e);
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

        private void returnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            allerRetour=!allerRetour;
            retourCalendar.Visible = !retourCalendar.Visible;
            RetourDateLabel.Visible = !RetourDateLabel.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectionVilleDepartComboBox.SelectedItem == null) { MessageBox.Show("Entrez une ville de départ"); }
            if (SelectionVilleArriveeComboBox.SelectedItem == null) { MessageBox.Show("Entrez une ville d'arrivée"); }
            if (selectionVilleDepartComboBox.SelectedItem == SelectionVilleArriveeComboBox.SelectedItem && selectionVilleDepartComboBox.SelectedItem != null) { MessageBox.Show("Choisissez une ville de départ et d'arrivée différente"); }
            if (departCalendar.SelectionRange.Start == null) { MessageBox.Show("Sélectionnez une date de départ"); }
            if (retourCalendar.SelectionRange.Start == null && allerRetour) { MessageBox.Show("Sélectionnez une date de retour"); }
            MessageBox.Show(departCalendar.SelectionRange.Start.ToShortDateString());


            if (!heureDepartLabel.Visible)
            {
                heureDepartLabel.Visible = true;
                heureDepartListBox.Visible = true;
                heureDepartListBox.Items.Add("11h20");
                if (allerRetour)
                {
                    heureRetourLabel.Visible = true;
                    heureRetourListBox.Visible = true;
                }
            }
            
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            allerRetour = false;
            ARCheckbox.Checked = false;
            heureDepartLabel.Visible = false;
            heureDepartListBox.Visible = false;
            heureRetourLabel.Visible = false;
            heureRetourListBox.Visible = false;
            selectionVilleDepartComboBox.SelectedItem = null;
            SelectionVilleArriveeComboBox.SelectedItem = null;
        }
    }
}
