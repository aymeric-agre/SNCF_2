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
            this.myTicketsTabPage = new System.Windows.Forms.TabPage();
            this.myAccountTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // myAccountTabControl
            // 
            this.myAccountTabControl.Controls.Add(this.myProfilTabPage);
            this.myAccountTabControl.Controls.Add(this.myTicketsTabPage);
            this.myAccountTabControl.Location = new System.Drawing.Point(12, 12);
            this.myAccountTabControl.Name = "myAccountTabControl";
            this.myAccountTabControl.SelectedIndex = 0;
            this.myAccountTabControl.Size = new System.Drawing.Size(260, 237);
            this.myAccountTabControl.TabIndex = 0;
            // 
            // myProfilTabPage
            // 
            this.myProfilTabPage.Location = new System.Drawing.Point(4, 22);
            this.myProfilTabPage.Name = "myProfilTabPage";
            this.myProfilTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.myProfilTabPage.Size = new System.Drawing.Size(252, 211);
            this.myProfilTabPage.TabIndex = 0;
            this.myProfilTabPage.Text = "Mes informations";
            this.myProfilTabPage.UseVisualStyleBackColor = true;
            // 
            // myTicketsTabPage
            // 
            this.myTicketsTabPage.Location = new System.Drawing.Point(4, 22);
            this.myTicketsTabPage.Name = "myTicketsTabPage";
            this.myTicketsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.myTicketsTabPage.Size = new System.Drawing.Size(252, 211);
            this.myTicketsTabPage.TabIndex = 1;
            this.myTicketsTabPage.Text = "Mes Réservations";
            this.myTicketsTabPage.UseVisualStyleBackColor = true;
            this.myTicketsTabPage.Click += new System.EventHandler(this.myTicketsTabPage_Click);
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.myAccountTabControl);
            this.Name = "MyAccount";
            this.Text = "Mon Compte";
            this.myAccountTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl myAccountTabControl;
        private System.Windows.Forms.TabPage myProfilTabPage;
        private System.Windows.Forms.TabPage myTicketsTabPage;
    }
}