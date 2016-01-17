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
        //bool situationPlace = false; //fenêtre = true, couloir = false
        List<int> prixAller = new List<int>();
        List<DateTime> heureAller = new List<DateTime>();
        List<DateTime> heureRetour = new List<DateTime>();
        List<int> prixRetour = new List<int>();
        string queryAchat;
        float modificateurPrix;
        private DataGridView dg = null;

        public MyAccountForm(client loggedClient)
        {
            thisClient = loggedClient;
            connString = "Server=localhost;Port=3306;Database=sncf;uid=root;password=root";
            conn = new MySqlConnection(connString);
            command = conn.CreateCommand();
            if (thisClient.age != null) { modificateurPrix = 1f - Math.Abs((float)thisClient.age / 100 - 0.5f); }
            else { modificateurPrix = 1f; }
            InitializeComponent();
        }

        private void myTicketsTabPage_Load(object sender, EventArgs e)
        {
            dg = this.myTicketsGridView;
            command.CommandText = "Select * from billet where (idclient='" + thisClient.idclient + "')";
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                conn.Open();

                DataSet ds = new DataSet();
                da.Fill(ds, "billet");
                this.myTicketsGridView.DataSource = ds.Tables["billet"];
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
            this.tauxReductionLabel.Text = Math.Abs((float)thisClient.age - 50).ToString() + " %";
        }

        private void modifyProfilButton_Click(object sender, EventArgs e)
        {
            string textModifyProfilButton;

            if(modifying)
            {
                thisClient.login = this.loginTextBox.Text;
                thisClient.password = this.passwordTextBox.Text;
                thisClient.nom = this.nomTextBox.Text;
                thisClient.age = int.Parse(this.ageTextBox.Text);
                this.tauxReductionLabel.Text = Math.Abs((float)thisClient.age - 50).ToString() + " %";
                thisClient.reduction = Math.Abs((float)thisClient.age / 100 - 0.5f);
                textModifyProfilButton = "Modifier mes informations";
                modifying = false;
                try
                {
                    conn.Open();
                    command.CommandText = "UPDATE client SET login = '" + thisClient.login + "', password = '" + thisClient.password + "', age = '" + thisClient.age.ToString() +"', nom = '" + thisClient.nom + "' Where idclient = '" + thisClient.idclient + "';";
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }                
            }
            else
            {
                textModifyProfilButton = "Mettre à jour mon profil";
                modifying = true;
            }
            this.passwordTextBox.ReadOnly = !modifying;
            this.loginTextBox.ReadOnly = !modifying;
            this.nomTextBox.ReadOnly = !modifying;
            this.ageTextBox.ReadOnly = !modifying;
            this.modifyProfilButton.Text = textModifyProfilButton;
        }

        private void MyAccountForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sncfDataSet.billet' table. You can move, or remove it, as needed.
            myProfilTabPage_Load(sender, e);
            myTicketsTabPage_Load(sender, e);
            try
            {
                conn.Open();
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
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
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
            string errorMessage = "";
            if (selectionVilleDepartComboBox.SelectedItem == null) { errorMessage += "Entrez une ville de départ \n"; }
            if (SelectionVilleArriveeComboBox.SelectedItem == null) { errorMessage += "Entrez une ville d'arrivée \n"; }
            if (selectionVilleDepartComboBox.SelectedItem == SelectionVilleArriveeComboBox.SelectedItem && selectionVilleDepartComboBox.SelectedItem != null) { errorMessage += "Choisissez une ville de départ et d'arrivée différente \n"; }
            if (departCalendar.SelectionRange.Start == null) { errorMessage += "Sélectionnez une date de départ \n"; }
            if (retourCalendar.SelectionRange.Start == null && allerRetour) { errorMessage += "Sélectionnez une date de retour \n"; }
            if (retourCalendar.SelectionRange.Start < departCalendar.SelectionRange.Start && allerRetour && departCalendar.SelectionRange.Start != null) { errorMessage += "Choisissez une date de retour après la date de départ \n"; }
            if (situationPlaceComboBox.SelectedItem == null) { errorMessage += "Sélectionnez une situation pour la place \n"; }

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                if (!heureDepartLabel.Visible)
                {
                    selectionVilleDepartComboBox.Enabled = false;
                    SelectionVilleArriveeComboBox.Enabled = false;
                    departCalendar.Enabled = false;
                    retourCalendar.Enabled = false;
                    returnCheckBox.Enabled = false;
                    situationPlaceComboBox.Enabled = false;
                    heureDepartLabel.Visible = true;
                    prixAllerBrut.Visible = true;
                    prixNetAller.Visible = true;
                    prixAllerBrut.Text = "";
                    prixNetAller.Text = "";
                    PrixNetAllerLabel.Visible = true;
                    prixBrutAllerLabel.Visible = true;
                    heureDepartListBox.Visible = true;
                    validationAchatButton.Visible = true;
                    heureAller.Clear();
                    Random rnd = new Random();
                    for (int i = 0; i < 9; i++)
                    {
                        DateTime heure = departCalendar.SelectionRange.Start.Add((new TimeSpan(rnd.Next(i * 2 + 4, i * 2 + 5), rnd.Next(1, 59), 0)));
                        heureDepartListBox.Items.Add(heure);
                        heureAller.Add(heure);
                        prixAller.Add(rnd.Next(50, 150));
                    }
                    if (allerRetour)
                    {
                        heureRetour.Clear();
                        heureRetourLabel.Visible = true;
                        PrixRetourBrut.Visible = true;
                        prixNetRetour.Visible = true;
                        PrixNetRetourLabel.Visible = true;
                        prixBrutRetourLabel.Visible = true;
                        heureRetourListBox.Visible = true;
                        prixAllerBrut.Text = "";
                        prixNetAller.Text = "";
                        for (int i = 0; i < 9; i++)
                        {
                            DateTime heure = retourCalendar.SelectionRange.Start.Add((new TimeSpan(rnd.Next(i * 2 + 4, i * 2 + 5), rnd.Next(1, 59), 0)));
                            heureRetourListBox.Items.Add(heure);
                            heureRetour.Add(heure);
                            prixRetour.Add(rnd.Next(50, 150));
                        }
                    }
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            selectionVilleDepartComboBox.Enabled = true;
            SelectionVilleArriveeComboBox.Enabled = true;
            departCalendar.Enabled = true;
            retourCalendar.Enabled = true;
            returnCheckBox.Enabled = true;
            situationPlaceComboBox.Enabled = true;

            //allerRetour = false;
            returnCheckBox.Checked = false;
            heureDepartLabel.Visible = false;
            heureDepartListBox.Visible = false;
            heureRetourLabel.Visible = false;
            heureRetourListBox.Visible = false;
            prixAllerBrut.Visible = false;
            prixNetAller.Visible = false;
            prixNetRetour.Visible = false;
            PrixNetAllerLabel.Visible = false;
            PrixNetRetourLabel.Visible = false;
            prixBrutAllerLabel.Visible = false;
            prixBrutRetourLabel.Visible = false;
            PrixRetourBrut.Visible = false;
            validationAchatButton.Visible = false;
            selectionVilleDepartComboBox.SelectedItem = null;
            SelectionVilleArriveeComboBox.SelectedItem = null;
            situationPlaceComboBox.SelectedItem = null;
            heureDepartListBox.Items.Clear();
            heureRetourListBox.Items.Clear();
        }

        private void heureDepartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            prixAllerBrut.Text = prixAller[heureDepartListBox.SelectedIndex].ToString() + " €";
            prixNetAller.Text = (prixAller[heureDepartListBox.SelectedIndex] * modificateurPrix).ToString() + " €";
        }

        private void heureRetourListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrixRetourBrut.Text = prixRetour[heureRetourListBox.SelectedIndex].ToString() + " €";
            prixNetRetour.Text = (prixRetour[heureRetourListBox.SelectedIndex] * modificateurPrix).ToString() + " €";

        }

        private void validationAchatButton_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (heureDepartListBox.SelectedItem == null) { errorMessage += "Choisissez une heure de départ \n"; }
            if (heureRetourListBox.SelectedItem == null && allerRetour) { errorMessage += "Choisissez une heure de retour \n"; }

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                if (!allerRetour)
                {
                    MessageBox.Show("Commande validée, vous avez acheté un billet pour un prix de " + (prixAller[heureDepartListBox.SelectedIndex] * modificateurPrix).ToString() + " €");
                    Random rnd = new Random();
                    int idTrain = rnd.Next(1, 20);
                    int idVoiture = idTrain * 5 + rnd.Next(1, 5);
                    int idPlace;
                    if (situationPlaceComboBox.SelectedItem.ToString() == "couloir") { idPlace = idVoiture * 30 + rnd.Next(1, 15) * 2; }
                    else { idPlace = idVoiture * 30 + rnd.Next(1, 15) * 2 + 1; }
                    DateTime heureDepart = heureAller[heureDepartListBox.SelectedIndex];
                    DateTime heureArrivee = heureDepart.AddHours(rnd.Next(5, 10));
                    queryAchat = "INSERT INTO `sncf`.`billet` (`villeDepart`, `villeArrivee`, `gareDepart`, `gareArrivee`, `heureDepart`, `heureArrivee`, `prix`, `idtrain`, `idvoiture`, `idplace`, `idclient`) VALUES ('" + selectionVilleDepartComboBox.SelectedItem.ToString() + "', '" + SelectionVilleArriveeComboBox.SelectedItem.ToString() + "', '" + selectionVilleDepartComboBox.SelectedItem.ToString() + "- Gare', '" + SelectionVilleArriveeComboBox.SelectedItem.ToString() + "- Gare', STR_TO_DATE('" + heureDepart.ToString() + "', '%d/%m/%Y %H:%i:%s'), STR_TO_DATE('" + heureArrivee.ToString() + "', '%d/%m/%Y %H:%i:%s'), '" + (int)(prixAller[heureDepartListBox.SelectedIndex] * modificateurPrix) + "', '" + idTrain.ToString() + "', '" + idVoiture + "', '" + idPlace.ToString() + "', '" + thisClient.idclient.ToString() + "');";
                }
                else
                {
                    MessageBox.Show("Commande validée, vous avez acheté un billet aller-retour pour un prix de " + (prixAller[heureDepartListBox.SelectedIndex] * modificateurPrix + prixRetour[heureRetourListBox.SelectedIndex] * modificateurPrix).ToString() + " €");
                    Random rnd = new Random();
                    int idTrainAller = rnd.Next(1, 20);
                    int idVoitureAller = idTrainAller * 5 + rnd.Next(1, 5);
                    int idTrainRetour = rnd.Next(1, 20);
                    int idVoitureRetour = idTrainRetour * 5 + rnd.Next(1, 5);
                    int idPlaceRetour;
                    if (situationPlaceComboBox.SelectedItem.ToString() == "couloir") { idPlaceRetour = idVoitureRetour * 30 + rnd.Next(1, 15) * 2; }
                    else { idPlaceRetour = idVoitureRetour * 30 + rnd.Next(1, 15) * 2 + 1; }
                    int idPlaceAller;
                    if (situationPlaceComboBox.SelectedItem.ToString() == "couloir") { idPlaceAller = idVoitureAller * 30 + rnd.Next(1, 15) * 2; }
                    else { idPlaceAller = idVoitureAller * 30 + rnd.Next(1, 15) * 2 + 1; }
                    DateTime heureDepartAller = heureAller[heureDepartListBox.SelectedIndex];
                    DateTime heureArriveeAller = heureDepartAller.AddHours(rnd.Next(5, 10));
                    DateTime heureDepartRetour = heureRetour[heureRetourListBox.SelectedIndex];
                    DateTime heureArriveeRetour = heureDepartRetour.AddHours(rnd.Next(5, 10));
                    queryAchat = "INSERT INTO `sncf`.`billet` (`villeDepart`, `villeArrivee`, `gareDepart`, `gareArrivee`, `heureDepart`, `heureArrivee`, `prix`, `idtrain`, `idvoiture`, `idplace`, `idclient`) VALUES ('" + selectionVilleDepartComboBox.SelectedItem.ToString() + "', '" + SelectionVilleArriveeComboBox.SelectedItem.ToString() + "', '" + selectionVilleDepartComboBox.SelectedItem.ToString() + "- Gare', '" + SelectionVilleArriveeComboBox.SelectedItem.ToString() + "- Gare', STR_TO_DATE('" + heureDepartAller.ToString() + "', '%d/%m/%Y %H:%i:%s'), STR_TO_DATE('" + heureArriveeAller.ToString() + "', '%d/%m/%Y %H:%i:%s'), '" + (int)(prixAller[heureDepartListBox.SelectedIndex] * modificateurPrix) + "', '" + idTrainAller.ToString() + "', '" + idVoitureAller + "', '" + idPlaceAller.ToString() + "', '" + thisClient.idclient.ToString() +
                        "');INSERT INTO `sncf`.`billet` (`villeDepart`, `villeArrivee`, `gareDepart`, `gareArrivee`, `heureDepart`, `heureArrivee`, `prix`, `idtrain`, `idvoiture`, `idplace`, `idclient`) VALUES('" + SelectionVilleArriveeComboBox.SelectedItem.ToString() + "', '" + selectionVilleDepartComboBox.SelectedItem.ToString() + "', '" + SelectionVilleArriveeComboBox.SelectedItem.ToString() + "- Gare', '" + selectionVilleDepartComboBox.SelectedItem.ToString() + "- Gare', STR_TO_DATE('" + heureDepartRetour.ToString() + "', '%d/%m/%Y %H:%i:%s'), STR_TO_DATE('" + heureArriveeRetour.ToString() + "', '%d/%m/%Y %H:%i:%s'), '" + (int)(prixRetour[heureRetourListBox.SelectedIndex] * modificateurPrix) + "', '" + idTrainRetour.ToString() + "', '" + idVoitureRetour + "', '" + idPlaceRetour.ToString() + "', '" + thisClient.idclient.ToString() + "'); ";
                }
                conn.Open();
                try
                {
                    command.CommandText = queryAchat;
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                conn.Close();
                RefreshButton_Click(sender, e);
                myTicketsTabPage_Load(sender, e);
            }
        }

        private void cancelTickets_Click(object sender, EventArgs e)
        {
            dg = this.myTicketsGridView;
            try
            {
                conn.Open();
                foreach (DataGridViewRow row in dg.SelectedRows)
                {
                    command.CommandText = "DELETE FROM billet WHERE idclient = '" + thisClient.idclient + "' AND idbillet = '" + row.Cells["idbillet"].Value.ToString() + "';";
                    command.ExecuteNonQuery();
                }       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                    myTicketsTabPage_Load(sender, e);
                }
            }
        }
    }
}
