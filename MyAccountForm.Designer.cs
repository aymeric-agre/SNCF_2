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
            this.billetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sncfDataSet = new SNCF_2.sncfDataSet();
            this.newTicketTabPage = new System.Windows.Forms.TabPage();
            this.RetourDateLabel = new System.Windows.Forms.Label();
            this.departLabel = new System.Windows.Forms.Label();
            this.retourCalendar = new System.Windows.Forms.MonthCalendar();
            this.returnCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectionVilleArriveeComboBox = new System.Windows.Forms.ComboBox();
            this.villeDepartLabel = new System.Windows.Forms.Label();
            this.selectionVilleDepartComboBox = new System.Windows.Forms.ComboBox();
            this.departCalendar = new System.Windows.Forms.MonthCalendar();
            this.billetTableAdapter = new SNCF_2.sncfDataSetTableAdapters.billetTableAdapter();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.myAccountTabControl.SuspendLayout();
            this.myProfilTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sncfDataSet)).BeginInit();
            this.newTicketTabPage.SuspendLayout();
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
            this.modifyProfilButton.Location = new System.Drawing.Point(144, 131);
            this.modifyProfilButton.Name = "modifyProfilButton";
            this.modifyProfilButton.Size = new System.Drawing.Size(161, 23);
            this.modifyProfilButton.TabIndex = 21;
            this.modifyProfilButton.Text = "Modifier mes informations";
            this.modifyProfilButton.UseVisualStyleBackColor = true;
            this.modifyProfilButton.Click += new System.EventHandler(this.modifyProfilButton_Click);
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(62, 54);
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
            this.nomLabel.Size = new System.Drawing.Size(27, 13);
            this.nomLabel.TabIndex = 13;
            this.nomLabel.Text = "nom";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(27, 80);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(25, 13);
            this.ageLabel.TabIndex = 14;
            this.ageLabel.Text = "age";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(62, 80);
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
            this.loginLabel.Size = new System.Drawing.Size(29, 13);
            this.loginLabel.TabIndex = 16;
            this.loginLabel.Text = "login";
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
            this.passwordLabel.Size = new System.Drawing.Size(52, 13);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "password";
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
            this.myTicketsTabPage.Location = new System.Drawing.Point(4, 22);
            this.myTicketsTabPage.Name = "myTicketsTabPage";
            this.myTicketsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.myTicketsTabPage.Size = new System.Drawing.Size(1062, 230);
            this.myTicketsTabPage.TabIndex = 1;
            this.myTicketsTabPage.Text = "Mes Réservations";
            this.myTicketsTabPage.UseVisualStyleBackColor = true;
            // 
            // billetBindingSource
            // 
            this.billetBindingSource.DataMember = "billet";
            this.billetBindingSource.DataSource = this.sncfDataSet;
            // 
            // sncfDataSet
            // 
            this.sncfDataSet.DataSetName = "sncfDataSet";
            this.sncfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newTicketTabPage
            // 
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
            // RetourDateLabel
            // 
            this.RetourDateLabel.AutoSize = true;
            this.RetourDateLabel.Location = new System.Drawing.Point(602, 24);
            this.RetourDateLabel.Name = "RetourDateLabel";
            this.RetourDateLabel.Size = new System.Drawing.Size(75, 13);
            this.RetourDateLabel.TabIndex = 8;
            this.RetourDateLabel.Text = "Date de retour";
            this.RetourDateLabel.Visible = false;
            // 
            // departLabel
            // 
            this.departLabel.AutoSize = true;
            this.departLabel.Location = new System.Drawing.Point(283, 24);
            this.departLabel.Name = "departLabel";
            this.departLabel.Size = new System.Drawing.Size(78, 13);
            this.departLabel.TabIndex = 7;
            this.departLabel.Text = "Date de départ";
            // 
            // retourCalendar
            // 
            this.retourCalendar.Location = new System.Drawing.Point(524, 46);
            this.retourCalendar.Name = "retourCalendar";
            this.retourCalendar.TabIndex = 6;
            this.retourCalendar.Visible = false;
            // 
            // returnCheckBox
            // 
            this.returnCheckBox.AutoSize = true;
            this.returnCheckBox.Location = new System.Drawing.Point(40, 146);
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
            this.label1.Location = new System.Drawing.Point(37, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ville d\'arrivée";
            // 
            // SelectionVilleArriveeComboBox
            // 
            this.SelectionVilleArriveeComboBox.FormattingEnabled = true;
            this.SelectionVilleArriveeComboBox.Location = new System.Drawing.Point(40, 99);
            this.SelectionVilleArriveeComboBox.Name = "SelectionVilleArriveeComboBox";
            this.SelectionVilleArriveeComboBox.Size = new System.Drawing.Size(122, 21);
            this.SelectionVilleArriveeComboBox.TabIndex = 3;
            // 
            // villeDepartLabel
            // 
            this.villeDepartLabel.AutoSize = true;
            this.villeDepartLabel.Location = new System.Drawing.Point(37, 30);
            this.villeDepartLabel.Name = "villeDepartLabel";
            this.villeDepartLabel.Size = new System.Drawing.Size(74, 13);
            this.villeDepartLabel.TabIndex = 2;
            this.villeDepartLabel.Text = "Ville de départ";
            this.villeDepartLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // selectionVilleDepartComboBox
            // 
            this.selectionVilleDepartComboBox.FormattingEnabled = true;
            this.selectionVilleDepartComboBox.Location = new System.Drawing.Point(40, 46);
            this.selectionVilleDepartComboBox.Name = "selectionVilleDepartComboBox";
            this.selectionVilleDepartComboBox.Size = new System.Drawing.Size(122, 21);
            this.selectionVilleDepartComboBox.TabIndex = 1;
            this.selectionVilleDepartComboBox.SelectedIndexChanged += new System.EventHandler(this.selectionVilleLabel_SelectedIndexChanged);
            // 
            // departCalendar
            // 
            this.departCalendar.Location = new System.Drawing.Point(208, 46);
            this.departCalendar.Name = "departCalendar";
            this.departCalendar.TabIndex = 0;
            this.departCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // billetTableAdapter
            // 
            this.billetTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.billetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sncfDataSet)).EndInit();
            this.newTicketTabPage.ResumeLayout(false);
            this.newTicketTabPage.PerformLayout();
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
        private sncfDataSet sncfDataSet;
        private System.Windows.Forms.BindingSource billetBindingSource;
        private sncfDataSetTableAdapters.billetTableAdapter billetTableAdapter;
        private System.Windows.Forms.TabPage newTicketTabPage;
        private System.Windows.Forms.MonthCalendar departCalendar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label villeDepartLabel;
        private System.Windows.Forms.ComboBox selectionVilleDepartComboBox;
        private System.Windows.Forms.ComboBox SelectionVilleArriveeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox returnCheckBox;
        private System.Windows.Forms.MonthCalendar retourCalendar;
        private System.Windows.Forms.Label RetourDateLabel;
        private System.Windows.Forms.Label departLabel;
    }
}