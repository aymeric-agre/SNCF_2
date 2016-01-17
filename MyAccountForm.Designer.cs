namespace SNCF_2
{
    partial class MyAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.myAccountTabControl = new System.Windows.Forms.TabControl();
            this.myProfilTabPage = new System.Windows.Forms.TabPage();
            this.modifyProfilButton = new System.Windows.Forms.Button();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.nomLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.myTicketsTabPage = new System.Windows.Forms.TabPage();
            this.cancelTickets = new System.Windows.Forms.Button();
            this.myTicketsGridView = new System.Windows.Forms.DataGridView();
            this.newTicketTabPage = new System.Windows.Forms.TabPage();
            this.prixNetRetour = new System.Windows.Forms.Label();
            this.prixNetAller = new System.Windows.Forms.Label();
            this.PrixNetRetourLabel = new System.Windows.Forms.Label();
            this.PrixNetAllerLabel = new System.Windows.Forms.Label();
            this.prixBrutRetourLabel = new System.Windows.Forms.Label();
            this.prixBrutAllerLabel = new System.Windows.Forms.Label();
            this.validationAchatButton = new System.Windows.Forms.Button();
            this.PrixRetourBrut = new System.Windows.Forms.Label();
            this.prixAllerBrut = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.heureRetourLabel = new System.Windows.Forms.Label();
            this.heureDepartLabel = new System.Windows.Forms.Label();
            this.heureRetourListBox = new System.Windows.Forms.ListBox();
            this.heureDepartListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SituationLabel = new System.Windows.Forms.Label();
            this.situationPlaceComboBox = new System.Windows.Forms.ComboBox();
            this.RetourDateLabel = new System.Windows.Forms.Label();
            this.departLabel = new System.Windows.Forms.Label();
            this.retourCalendar = new System.Windows.Forms.MonthCalendar();
            this.returnCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectionVilleArriveeComboBox = new System.Windows.Forms.ComboBox();
            this.villeDepartLabel = new System.Windows.Forms.Label();
            this.selectionVilleDepartComboBox = new System.Windows.Forms.ComboBox();
            this.departCalendar = new System.Windows.Forms.MonthCalendar();
            this.billetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reductionLabel = new System.Windows.Forms.Label();
            this.tauxReductionLabel = new System.Windows.Forms.Label();
            this.myAccountTabControl.SuspendLayout();
            this.myProfilTabPage.SuspendLayout();
            this.myTicketsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myTicketsGridView)).BeginInit();
            this.newTicketTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // myAccountTabControl
            // 
            this.myAccountTabControl.Controls.Add(this.myProfilTabPage);
            this.myAccountTabControl.Controls.Add(this.myTicketsTabPage);
            this.myAccountTabControl.Controls.Add(this.newTicketTabPage);
            this.myAccountTabControl.Location = new System.Drawing.Point(12, 12);
            this.myAccountTabControl.Name = "myAccountTabControl";
            this.myAccountTabControl.SelectedIndex = 0;
            this.myAccountTabControl.Size = new System.Drawing.Size(1070, 256);
            this.myAccountTabControl.TabIndex = 0;
            // 
            // myProfilTabPage
            // 
            this.myProfilTabPage.Controls.Add(this.tauxReductionLabel);
            this.myProfilTabPage.Controls.Add(this.reductionLabel);
            this.myProfilTabPage.Controls.Add(this.modifyProfilButton);
            this.myProfilTabPage.Controls.Add(this.nomTextBox);
            this.myProfilTabPage.Controls.Add(this.nomLabel);
            this.myProfilTabPage.Controls.Add(this.ageLabel);
            this.myProfilTabPage.Controls.Add(this.ageTextBox);
            this.myProfilTabPage.Controls.Add(this.loginLabel);
            this.myProfilTabPage.Controls.Add(this.loginTextBox);
            this.myProfilTabPage.Controls.Add(this.passwordLabel);
            this.myProfilTabPage.Controls.Add(this.passwordTextBox);
            this.myProfilTabPage.Location = new System.Drawing.Point(4, 22);
            this.myProfilTabPage.Name = "myProfilTabPage";
            this.myProfilTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.myProfilTabPage.Size = new System.Drawing.Size(1062, 230);
            this.myProfilTabPage.TabIndex = 0;
            this.myProfilTabPage.Text = "Mes informations";
            this.myProfilTabPage.UseVisualStyleBackColor = true;
            // 
            // modifyProfilButton
            // 
            this.modifyProfilButton.Location = new System.Drawing.Point(352, 152);
            this.modifyProfilButton.Name = "modifyProfilButton";
            this.modifyProfilButton.Size = new System.Drawing.Size(161, 23);
            this.modifyProfilButton.TabIndex = 21;
            this.modifyProfilButton.Text = "Modifier mes informations";
            this.modifyProfilButton.UseVisualStyleBackColor = true;
            this.modifyProfilButton.Click += new System.EventHandler(this.modifyProfilButton_Click);
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(109, 54);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.ReadOnly = true;
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 20;
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(25, 54);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(68, 13);
            this.nomLabel.TabIndex = 13;
            this.nomLabel.Text = "Prénom Nom";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(27, 80);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 14;
            this.ageLabel.Text = "Age";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(109, 80);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.ReadOnly = true;
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 15;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(294, 54);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 16;
            this.loginLabel.Text = "Login";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(333, 54);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.ReadOnly = true;
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 17;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(271, 80);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(333, 80);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 19;
            // 
            // myTicketsTabPage
            // 
            this.myTicketsTabPage.Controls.Add(this.cancelTickets);
            this.myTicketsTabPage.Controls.Add(this.myTicketsGridView);
            this.myTicketsTabPage.Location = new System.Drawing.Point(4, 22);
            this.myTicketsTabPage.Name = "myTicketsTabPage";
            this.myTicketsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.myTicketsTabPage.Size = new System.Drawing.Size(1062, 230);
            this.myTicketsTabPage.TabIndex = 1;
            this.myTicketsTabPage.Text = "Mes Réservations";
            this.myTicketsTabPage.UseVisualStyleBackColor = true;
            // 
            // cancelTickets
            // 
            this.cancelTickets.Location = new System.Drawing.Point(470, 187);
            this.cancelTickets.Name = "cancelTickets";
            this.cancelTickets.Size = new System.Drawing.Size(219, 23);
            this.cancelTickets.TabIndex = 1;
            this.cancelTickets.Text = "Annuler les billets sélectionnés";
            this.cancelTickets.UseVisualStyleBackColor = true;
            this.cancelTickets.Click += new System.EventHandler(this.cancelTickets_Click);
            // 
            // myTicketsGridView
            // 
            this.myTicketsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myTicketsGridView.Location = new System.Drawing.Point(7, 6);
            this.myTicketsGridView.Name = "myTicketsGridView";
            this.myTicketsGridView.Size = new System.Drawing.Size(1049, 150);
            this.myTicketsGridView.TabIndex = 0;
            // 
            // newTicketTabPage
            // 
            this.newTicketTabPage.Controls.Add(this.prixNetRetour);
            this.newTicketTabPage.Controls.Add(this.prixNetAller);
            this.newTicketTabPage.Controls.Add(this.PrixNetRetourLabel);
            this.newTicketTabPage.Controls.Add(this.PrixNetAllerLabel);
            this.newTicketTabPage.Controls.Add(this.prixBrutRetourLabel);
            this.newTicketTabPage.Controls.Add(this.prixBrutAllerLabel);
            this.newTicketTabPage.Controls.Add(this.validationAchatButton);
            this.newTicketTabPage.Controls.Add(this.PrixRetourBrut);
            this.newTicketTabPage.Controls.Add(this.prixAllerBrut);
            this.newTicketTabPage.Controls.Add(this.RefreshButton);
            this.newTicketTabPage.Controls.Add(this.heureRetourLabel);
            this.newTicketTabPage.Controls.Add(this.heureDepartLabel);
            this.newTicketTabPage.Controls.Add(this.heureRetourListBox);
            this.newTicketTabPage.Controls.Add(this.heureDepartListBox);
            this.newTicketTabPage.Controls.Add(this.button1);
            this.newTicketTabPage.Controls.Add(this.SituationLabel);
            this.newTicketTabPage.Controls.Add(this.situationPlaceComboBox);
            this.newTicketTabPage.Controls.Add(this.RetourDateLabel);
            this.newTicketTabPage.Controls.Add(this.departLabel);
            this.newTicketTabPage.Controls.Add(this.retourCalendar);
            this.newTicketTabPage.Controls.Add(this.returnCheckBox);
            this.newTicketTabPage.Controls.Add(this.label1);
            this.newTicketTabPage.Controls.Add(this.SelectionVilleArriveeComboBox);
            this.newTicketTabPage.Controls.Add(this.villeDepartLabel);
            this.newTicketTabPage.Controls.Add(this.selectionVilleDepartComboBox);
            this.newTicketTabPage.Controls.Add(this.departCalendar);
            this.newTicketTabPage.Location = new System.Drawing.Point(4, 22);
            this.newTicketTabPage.Name = "newTicketTabPage";
            this.newTicketTabPage.Size = new System.Drawing.Size(1062, 230);
            this.newTicketTabPage.TabIndex = 2;
            this.newTicketTabPage.Text = "Acheter un billet";
            this.newTicketTabPage.UseVisualStyleBackColor = true;
            this.newTicketTabPage.Click += new System.EventHandler(this.newTicketTabPage_Click);
            // 
            // prixNetRetour
            // 
            this.prixNetRetour.AutoSize = true;
            this.prixNetRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixNetRetour.Location = new System.Drawing.Point(854, 178);
            this.prixNetRetour.Name = "prixNetRetour";
            this.prixNetRetour.Size = new System.Drawing.Size(14, 20);
            this.prixNetRetour.TabIndex = 25;
            this.prixNetRetour.Text = " ";
            // 
            // prixNetAller
            // 
            this.prixNetAller.AutoSize = true;
            this.prixNetAller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixNetAller.Location = new System.Drawing.Point(854, 83);
            this.prixNetAller.Name = "prixNetAller";
            this.prixNetAller.Size = new System.Drawing.Size(14, 20);
            this.prixNetAller.TabIndex = 24;
            this.prixNetAller.Text = " ";
            // 
            // PrixNetRetourLabel
            // 
            this.PrixNetRetourLabel.AutoSize = true;
            this.PrixNetRetourLabel.Location = new System.Drawing.Point(850, 165);
            this.PrixNetRetourLabel.Name = "PrixNetRetourLabel";
            this.PrixNetRetourLabel.Size = new System.Drawing.Size(98, 13);
            this.PrixNetRetourLabel.TabIndex = 23;
            this.PrixNetRetourLabel.Text = "Prix avec réduction";
            this.PrixNetRetourLabel.Visible = false;
            // 
            // PrixNetAllerLabel
            // 
            this.PrixNetAllerLabel.AutoSize = true;
            this.PrixNetAllerLabel.Location = new System.Drawing.Point(850, 66);
            this.PrixNetAllerLabel.Name = "PrixNetAllerLabel";
            this.PrixNetAllerLabel.Size = new System.Drawing.Size(98, 13);
            this.PrixNetAllerLabel.TabIndex = 22;
            this.PrixNetAllerLabel.Text = "Prix avec réduction";
            this.PrixNetAllerLabel.Visible = false;
            // 
            // prixBrutRetourLabel
            // 
            this.prixBrutRetourLabel.AutoSize = true;
            this.prixBrutRetourLabel.Location = new System.Drawing.Point(850, 127);
            this.prixBrutRetourLabel.Name = "prixBrutRetourLabel";
            this.prixBrutRetourLabel.Size = new System.Drawing.Size(45, 13);
            this.prixBrutRetourLabel.TabIndex = 21;
            this.prixBrutRetourLabel.Text = "Prix brut";
            this.prixBrutRetourLabel.Visible = false;
            // 
            // prixBrutAllerLabel
            // 
            this.prixBrutAllerLabel.AutoSize = true;
            this.prixBrutAllerLabel.Location = new System.Drawing.Point(850, 24);
            this.prixBrutAllerLabel.Name = "prixBrutAllerLabel";
            this.prixBrutAllerLabel.Size = new System.Drawing.Size(45, 13);
            this.prixBrutAllerLabel.TabIndex = 20;
            this.prixBrutAllerLabel.Text = "Prix brut";
            this.prixBrutAllerLabel.Visible = false;
            // 
            // validationAchatButton
            // 
            this.validationAchatButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.validationAchatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationAchatButton.ForeColor = System.Drawing.Color.Black;
            this.validationAchatButton.Location = new System.Drawing.Point(956, 91);
            this.validationAchatButton.Name = "validationAchatButton";
            this.validationAchatButton.Size = new System.Drawing.Size(103, 63);
            this.validationAchatButton.TabIndex = 19;
            this.validationAchatButton.Text = "Valider la commande";
            this.validationAchatButton.UseVisualStyleBackColor = false;
            this.validationAchatButton.Visible = false;
            this.validationAchatButton.Click += new System.EventHandler(this.validationAchatButton_Click);
            // 
            // PrixRetourBrut
            // 
            this.PrixRetourBrut.AutoSize = true;
            this.PrixRetourBrut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrixRetourBrut.Location = new System.Drawing.Point(854, 141);
            this.PrixRetourBrut.Name = "PrixRetourBrut";
            this.PrixRetourBrut.Size = new System.Drawing.Size(14, 20);
            this.PrixRetourBrut.TabIndex = 18;
            this.PrixRetourBrut.Text = " ";
            // 
            // prixAllerBrut
            // 
            this.prixAllerBrut.AutoSize = true;
            this.prixAllerBrut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixAllerBrut.Location = new System.Drawing.Point(854, 46);
            this.prixAllerBrut.Name = "prixAllerBrut";
            this.prixAllerBrut.Size = new System.Drawing.Size(14, 20);
            this.prixAllerBrut.TabIndex = 17;
            this.prixAllerBrut.Text = " ";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(21, 192);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(86, 35);
            this.RefreshButton.TabIndex = 16;
            this.RefreshButton.Text = "Rafraîchir";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // heureRetourLabel
            // 
            this.heureRetourLabel.AutoSize = true;
            this.heureRetourLabel.Location = new System.Drawing.Point(703, 123);
            this.heureRetourLabel.Name = "heureRetourLabel";
            this.heureRetourLabel.Size = new System.Drawing.Size(81, 13);
            this.heureRetourLabel.TabIndex = 15;
            this.heureRetourLabel.Text = "Heure de retour";
            this.heureRetourLabel.Visible = false;
            // 
            // heureDepartLabel
            // 
            this.heureDepartLabel.AutoSize = true;
            this.heureDepartLabel.Location = new System.Drawing.Point(703, 24);
            this.heureDepartLabel.Name = "heureDepartLabel";
            this.heureDepartLabel.Size = new System.Drawing.Size(84, 13);
            this.heureDepartLabel.TabIndex = 14;
            this.heureDepartLabel.Text = "Heure de départ";
            this.heureDepartLabel.Visible = false;
            // 
            // heureRetourListBox
            // 
            this.heureRetourListBox.FormattingEnabled = true;
            this.heureRetourListBox.Location = new System.Drawing.Point(706, 139);
            this.heureRetourListBox.Name = "heureRetourListBox";
            this.heureRetourListBox.Size = new System.Drawing.Size(142, 69);
            this.heureRetourListBox.TabIndex = 13;
            this.heureRetourListBox.Visible = false;
            this.heureRetourListBox.SelectedIndexChanged += new System.EventHandler(this.heureRetourListBox_SelectedIndexChanged);
            // 
            // heureDepartListBox
            // 
            this.heureDepartListBox.FormattingEnabled = true;
            this.heureDepartListBox.Location = new System.Drawing.Point(706, 46);
            this.heureDepartListBox.Name = "heureDepartListBox";
            this.heureDepartListBox.Size = new System.Drawing.Size(142, 69);
            this.heureDepartListBox.TabIndex = 12;
            this.heureDepartListBox.Visible = false;
            this.heureDepartListBox.SelectedIndexChanged += new System.EventHandler(this.heureDepartListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "Voir les offres et les prix";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SituationLabel
            // 
            this.SituationLabel.AutoSize = true;
            this.SituationLabel.Location = new System.Drawing.Point(4, 146);
            this.SituationLabel.Name = "SituationLabel";
            this.SituationLabel.Size = new System.Drawing.Size(103, 13);
            this.SituationLabel.TabIndex = 10;
            this.SituationLabel.Text = "Situation de la place";
            // 
            // situationPlaceComboBox
            // 
            this.situationPlaceComboBox.FormattingEnabled = true;
            this.situationPlaceComboBox.Items.AddRange(new object[] {
            "fenêtre",
            "couloir"});
            this.situationPlaceComboBox.Location = new System.Drawing.Point(7, 165);
            this.situationPlaceComboBox.Name = "situationPlaceComboBox";
            this.situationPlaceComboBox.Size = new System.Drawing.Size(121, 21);
            this.situationPlaceComboBox.TabIndex = 9;
            // 
            // RetourDateLabel
            // 
            this.RetourDateLabel.AutoSize = true;
            this.RetourDateLabel.Location = new System.Drawing.Point(459, 24);
            this.RetourDateLabel.Name = "RetourDateLabel";
            this.RetourDateLabel.Size = new System.Drawing.Size(75, 13);
            this.RetourDateLabel.TabIndex = 8;
            this.RetourDateLabel.Text = "Date de retour";
            this.RetourDateLabel.Visible = false;
            // 
            // departLabel
            // 
            this.departLabel.AutoSize = true;
            this.departLabel.Location = new System.Drawing.Point(209, 24);
            this.departLabel.Name = "departLabel";
            this.departLabel.Size = new System.Drawing.Size(78, 13);
            this.departLabel.TabIndex = 7;
            this.departLabel.Text = "Date de départ";
            // 
            // retourCalendar
            // 
            this.retourCalendar.Location = new System.Drawing.Point(383, 46);
            this.retourCalendar.Name = "retourCalendar";
            this.retourCalendar.TabIndex = 6;
            this.retourCalendar.Visible = false;
            // 
            // returnCheckBox
            // 
            this.returnCheckBox.AutoSize = true;
            this.returnCheckBox.Location = new System.Drawing.Point(7, 127);
            this.returnCheckBox.Name = "returnCheckBox";
            this.returnCheckBox.Size = new System.Drawing.Size(76, 17);
            this.returnCheckBox.TabIndex = 5;
            this.returnCheckBox.Text = "Aller-retour";
            this.returnCheckBox.UseVisualStyleBackColor = true;
            this.returnCheckBox.CheckedChanged += new System.EventHandler(this.returnCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ville d\'arrivée";
            // 
            // SelectionVilleArriveeComboBox
            // 
            this.SelectionVilleArriveeComboBox.FormattingEnabled = true;
            this.SelectionVilleArriveeComboBox.Location = new System.Drawing.Point(5, 99);
            this.SelectionVilleArriveeComboBox.Name = "SelectionVilleArriveeComboBox";
            this.SelectionVilleArriveeComboBox.Size = new System.Drawing.Size(122, 21);
            this.SelectionVilleArriveeComboBox.TabIndex = 3;
            // 
            // villeDepartLabel
            // 
            this.villeDepartLabel.AutoSize = true;
            this.villeDepartLabel.Location = new System.Drawing.Point(2, 30);
            this.villeDepartLabel.Name = "villeDepartLabel";
            this.villeDepartLabel.Size = new System.Drawing.Size(74, 13);
            this.villeDepartLabel.TabIndex = 2;
            this.villeDepartLabel.Text = "Ville de départ";
            this.villeDepartLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // selectionVilleDepartComboBox
            // 
            this.selectionVilleDepartComboBox.FormattingEnabled = true;
            this.selectionVilleDepartComboBox.Location = new System.Drawing.Point(5, 46);
            this.selectionVilleDepartComboBox.Name = "selectionVilleDepartComboBox";
            this.selectionVilleDepartComboBox.Size = new System.Drawing.Size(122, 21);
            this.selectionVilleDepartComboBox.TabIndex = 1;
            this.selectionVilleDepartComboBox.SelectedIndexChanged += new System.EventHandler(this.selectionVilleLabel_SelectedIndexChanged);
            // 
            // departCalendar
            // 
            this.departCalendar.Location = new System.Drawing.Point(140, 46);
            this.departCalendar.Name = "departCalendar";
            this.departCalendar.TabIndex = 0;
            this.departCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // billetBindingSource
            // 
            this.billetBindingSource.DataMember = "billet";
            // 
            // reductionLabel
            // 
            this.reductionLabel.AutoSize = true;
            this.reductionLabel.Location = new System.Drawing.Point(565, 54);
            this.reductionLabel.Name = "reductionLabel";
            this.reductionLabel.Size = new System.Drawing.Size(56, 13);
            this.reductionLabel.TabIndex = 22;
            this.reductionLabel.Text = "Reduction";
            // 
            // tauxReductionLabel
            // 
            this.tauxReductionLabel.AutoSize = true;
            this.tauxReductionLabel.Location = new System.Drawing.Point(565, 83);
            this.tauxReductionLabel.Name = "tauxReductionLabel";
            this.tauxReductionLabel.Size = new System.Drawing.Size(0, 13);
            this.tauxReductionLabel.TabIndex = 23;
            // 
            // MyAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 288);
            this.Controls.Add(this.myAccountTabControl);
            this.Name = "MyAccountForm";
            this.Text = "Mon Compte";
            this.Load += new System.EventHandler(this.MyAccountForm_Load);
            this.myAccountTabControl.ResumeLayout(false);
            this.myProfilTabPage.ResumeLayout(false);
            this.myProfilTabPage.PerformLayout();
            this.myTicketsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myTicketsGridView)).EndInit();
            this.newTicketTabPage.ResumeLayout(false);
            this.newTicketTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl myAccountTabControl;
        private System.Windows.Forms.TabPage myProfilTabPage;
        private System.Windows.Forms.TabPage myTicketsTabPage;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Button modifyProfilButton;
        private System.Windows.Forms.BindingSource billetBindingSource;
        private System.Windows.Forms.TabPage newTicketTabPage;
        private System.Windows.Forms.MonthCalendar departCalendar;
        private System.Windows.Forms.Label villeDepartLabel;
        private System.Windows.Forms.ComboBox selectionVilleDepartComboBox;
        private System.Windows.Forms.ComboBox SelectionVilleArriveeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox returnCheckBox;
        private System.Windows.Forms.MonthCalendar retourCalendar;
        private System.Windows.Forms.Label RetourDateLabel;
        private System.Windows.Forms.Label departLabel;
        private System.Windows.Forms.ComboBox situationPlaceComboBox;
        private System.Windows.Forms.Label SituationLabel;
        private System.Windows.Forms.ListBox heureDepartListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label heureRetourLabel;
        private System.Windows.Forms.Label heureDepartLabel;
        private System.Windows.Forms.ListBox heureRetourListBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label PrixRetourBrut;
        private System.Windows.Forms.Label prixAllerBrut;
        private System.Windows.Forms.Button validationAchatButton;
        private System.Windows.Forms.Label prixBrutRetourLabel;
        private System.Windows.Forms.Label prixBrutAllerLabel;
        private System.Windows.Forms.Label PrixNetRetourLabel;
        private System.Windows.Forms.Label PrixNetAllerLabel;
        private System.Windows.Forms.Label prixNetAller;
        private System.Windows.Forms.Label prixNetRetour;
        private System.Windows.Forms.DataGridView myTicketsGridView;
        private System.Windows.Forms.Button cancelTickets;
        private System.Windows.Forms.Label tauxReductionLabel;
        private System.Windows.Forms.Label reductionLabel;
    }
}