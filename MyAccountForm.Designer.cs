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
            this.myAccountTabControl = new System.Windows.Forms.TabControl();
            this.myProfilTabPage = new System.Windows.Forms.TabPage();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.nomLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.myTicketsTabPage = new System.Windows.Forms.TabPage();
            this.modifyProfilButton = new System.Windows.Forms.Button();
            this.myAccountTabControl.SuspendLayout();
            this.myProfilTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // myAccountTabControl
            // 
            this.myAccountTabControl.Controls.Add(this.myProfilTabPage);
            this.myAccountTabControl.Controls.Add(this.myTicketsTabPage);
            this.myAccountTabControl.Location = new System.Drawing.Point(12, 12);
            this.myAccountTabControl.Name = "myAccountTabControl";
            this.myAccountTabControl.SelectedIndex = 0;
            this.myAccountTabControl.Size = new System.Drawing.Size(464, 196);
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
            this.myProfilTabPage.Size = new System.Drawing.Size(456, 170);
            this.myProfilTabPage.TabIndex = 0;
            this.myProfilTabPage.Text = "Mes informations";
            this.myProfilTabPage.UseVisualStyleBackColor = true;
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
            this.myTicketsTabPage.Size = new System.Drawing.Size(456, 170);
            this.myTicketsTabPage.TabIndex = 1;
            this.myTicketsTabPage.Text = "Mes Réservations";
            this.myTicketsTabPage.UseVisualStyleBackColor = true;
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
            // MyAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 220);
            this.Controls.Add(this.myAccountTabControl);
            this.Name = "MyAccountForm";
            this.Text = "Mon Compte";
            this.myAccountTabControl.ResumeLayout(false);
            this.myProfilTabPage.ResumeLayout(false);
            this.myProfilTabPage.PerformLayout();
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
    }
}