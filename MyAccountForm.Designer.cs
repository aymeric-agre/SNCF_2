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
            this.myTicketsGridView = new System.Windows.Forms.DataGridView();
            this.villeDepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeArriveeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gareDepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gareArriveeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureArriveeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtrainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvoitureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idplaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sncfDataSet = new SNCF_2.sncfDataSet();
            this.billetTableAdapter = new SNCF_2.sncfDataSetTableAdapters.billetTableAdapter();
            this.myAccountTabControl.SuspendLayout();
            this.myProfilTabPage.SuspendLayout();
            this.myTicketsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myTicketsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sncfDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // myAccountTabControl
            // 
            this.myAccountTabControl.Controls.Add(this.myProfilTabPage);
            this.myAccountTabControl.Controls.Add(this.myTicketsTabPage);
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
            this.myTicketsTabPage.Controls.Add(this.myTicketsGridView);
            this.myTicketsTabPage.Location = new System.Drawing.Point(4, 22);
            this.myTicketsTabPage.Name = "myTicketsTabPage";
            this.myTicketsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.myTicketsTabPage.Size = new System.Drawing.Size(1062, 230);
            this.myTicketsTabPage.TabIndex = 1;
            this.myTicketsTabPage.Text = "Mes Réservations";
            this.myTicketsTabPage.UseVisualStyleBackColor = true;
            // 
            // myTicketsGridView
            // 
            this.myTicketsGridView.AllowUserToAddRows = false;
            this.myTicketsGridView.AllowUserToDeleteRows = false;
            this.myTicketsGridView.AutoGenerateColumns = false;
            this.myTicketsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myTicketsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.villeDepartDataGridViewTextBoxColumn,
            this.villeArriveeDataGridViewTextBoxColumn,
            this.gareDepartDataGridViewTextBoxColumn,
            this.gareArriveeDataGridViewTextBoxColumn,
            this.heureDepartDataGridViewTextBoxColumn,
            this.heureArriveeDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.idtrainDataGridViewTextBoxColumn,
            this.idvoitureDataGridViewTextBoxColumn,
            this.idplaceDataGridViewTextBoxColumn});
            this.myTicketsGridView.DataSource = this.billetBindingSource;
            this.myTicketsGridView.Location = new System.Drawing.Point(7, 7);
            this.myTicketsGridView.Name = "myTicketsGridView";
            this.myTicketsGridView.ReadOnly = true;
            this.myTicketsGridView.Size = new System.Drawing.Size(1044, 217);
            this.myTicketsGridView.TabIndex = 0;
            // 
            // villeDepartDataGridViewTextBoxColumn
            // 
            this.villeDepartDataGridViewTextBoxColumn.DataPropertyName = "villeDepart";
            this.villeDepartDataGridViewTextBoxColumn.HeaderText = "villeDepart";
            this.villeDepartDataGridViewTextBoxColumn.Name = "villeDepartDataGridViewTextBoxColumn";
            this.villeDepartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // villeArriveeDataGridViewTextBoxColumn
            // 
            this.villeArriveeDataGridViewTextBoxColumn.DataPropertyName = "villeArrivee";
            this.villeArriveeDataGridViewTextBoxColumn.HeaderText = "villeArrivee";
            this.villeArriveeDataGridViewTextBoxColumn.Name = "villeArriveeDataGridViewTextBoxColumn";
            this.villeArriveeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gareDepartDataGridViewTextBoxColumn
            // 
            this.gareDepartDataGridViewTextBoxColumn.DataPropertyName = "gareDepart";
            this.gareDepartDataGridViewTextBoxColumn.HeaderText = "gareDepart";
            this.gareDepartDataGridViewTextBoxColumn.Name = "gareDepartDataGridViewTextBoxColumn";
            this.gareDepartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gareArriveeDataGridViewTextBoxColumn
            // 
            this.gareArriveeDataGridViewTextBoxColumn.DataPropertyName = "gareArrivee";
            this.gareArriveeDataGridViewTextBoxColumn.HeaderText = "gareArrivee";
            this.gareArriveeDataGridViewTextBoxColumn.Name = "gareArriveeDataGridViewTextBoxColumn";
            this.gareArriveeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heureDepartDataGridViewTextBoxColumn
            // 
            this.heureDepartDataGridViewTextBoxColumn.DataPropertyName = "heureDepart";
            this.heureDepartDataGridViewTextBoxColumn.HeaderText = "heureDepart";
            this.heureDepartDataGridViewTextBoxColumn.Name = "heureDepartDataGridViewTextBoxColumn";
            this.heureDepartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heureArriveeDataGridViewTextBoxColumn
            // 
            this.heureArriveeDataGridViewTextBoxColumn.DataPropertyName = "heureArrivee";
            this.heureArriveeDataGridViewTextBoxColumn.HeaderText = "heureArrivee";
            this.heureArriveeDataGridViewTextBoxColumn.Name = "heureArriveeDataGridViewTextBoxColumn";
            this.heureArriveeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idtrainDataGridViewTextBoxColumn
            // 
            this.idtrainDataGridViewTextBoxColumn.DataPropertyName = "idtrain";
            this.idtrainDataGridViewTextBoxColumn.HeaderText = "idtrain";
            this.idtrainDataGridViewTextBoxColumn.Name = "idtrainDataGridViewTextBoxColumn";
            this.idtrainDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idvoitureDataGridViewTextBoxColumn
            // 
            this.idvoitureDataGridViewTextBoxColumn.DataPropertyName = "idvoiture";
            this.idvoitureDataGridViewTextBoxColumn.HeaderText = "idvoiture";
            this.idvoitureDataGridViewTextBoxColumn.Name = "idvoitureDataGridViewTextBoxColumn";
            this.idvoitureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idplaceDataGridViewTextBoxColumn
            // 
            this.idplaceDataGridViewTextBoxColumn.DataPropertyName = "idplace";
            this.idplaceDataGridViewTextBoxColumn.HeaderText = "idplace";
            this.idplaceDataGridViewTextBoxColumn.Name = "idplaceDataGridViewTextBoxColumn";
            this.idplaceDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.myTicketsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myTicketsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sncfDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridView myTicketsGridView;
        private sncfDataSet sncfDataSet;
        private System.Windows.Forms.BindingSource billetBindingSource;
        private sncfDataSetTableAdapters.billetTableAdapter billetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDepartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeArriveeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gareDepartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gareArriveeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDepartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureArriveeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvoitureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idplaceDataGridViewTextBoxColumn;
    }
}