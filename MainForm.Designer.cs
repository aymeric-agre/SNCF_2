namespace SNCF_2
{
    partial class MainForm
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
            this.accountLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.createNewAccountButton = new System.Windows.Forms.Button();
            this.noAccountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.sncfPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sncfPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(194, 19);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(99, 13);
            this.accountLabel.TabIndex = 0;
            this.accountLabel.Text = "Compte Client Train";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(58, 50);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(86, 13);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Nom d\'Utilisateur";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(58, 75);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(72, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Mot de Passe";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(161, 47);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(161, 72);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(61, 208);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(150, 23);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Me Connecter";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // createNewAccountButton
            // 
            this.createNewAccountButton.Location = new System.Drawing.Point(286, 208);
            this.createNewAccountButton.Name = "createNewAccountButton";
            this.createNewAccountButton.Size = new System.Drawing.Size(139, 23);
            this.createNewAccountButton.TabIndex = 6;
            this.createNewAccountButton.Text = "Créer un Compte";
            this.createNewAccountButton.UseVisualStyleBackColor = true;
            this.createNewAccountButton.Visible = false;
            this.createNewAccountButton.Click += new System.EventHandler(this.createNewAccountButton_Click);
            // 
            // noAccountLinkLabel
            // 
            this.noAccountLinkLabel.AutoSize = true;
            this.noAccountLinkLabel.Location = new System.Drawing.Point(283, 192);
            this.noAccountLinkLabel.Name = "noAccountLinkLabel";
            this.noAccountLinkLabel.Size = new System.Drawing.Size(140, 13);
            this.noAccountLinkLabel.TabIndex = 7;
            this.noAccountLinkLabel.TabStop = true;
            this.noAccountLinkLabel.Text = "Pas de compte ? Cliquez ici.";
            this.noAccountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.noAccountLinkLabel_LinkClicked);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(58, 106);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Prénom Nom";
            this.nameLabel.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(161, 103);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.Visible = false;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(161, 138);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 10;
            this.ageTextBox.Visible = false;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(61, 141);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 11;
            this.ageLabel.Text = "Age";
            this.ageLabel.Visible = false;
            // 
            // sncfPictureBox
            // 
            this.sncfPictureBox.Image = global::SNCF_2.Properties.Resources.sncf_3d698314b0f11aef98e7c193f8d3a094;
            this.sncfPictureBox.Location = new System.Drawing.Point(295, 38);
            this.sncfPictureBox.Name = "sncfPictureBox";
            this.sncfPictureBox.Size = new System.Drawing.Size(253, 130);
            this.sncfPictureBox.TabIndex = 12;
            this.sncfPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 257);
            this.Controls.Add(this.sncfPictureBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.noAccountLinkLabel);
            this.Controls.Add(this.createNewAccountButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.accountLabel);
            this.Name = "MainForm";
            this.Text = "Gestionnaire de Billets de Train";
            ((System.ComponentModel.ISupportInitialize)(this.sncfPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button createNewAccountButton;
        private System.Windows.Forms.LinkLabel noAccountLinkLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.PictureBox sncfPictureBox;
    }
}

