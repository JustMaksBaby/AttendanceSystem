namespace AttendanceSystem
{
    partial class LoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.userTextBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.userLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.addUserLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            // 
            // userTextBox
            // 
            resources.ApplyResources(this.userTextBox, "userTextBox");
            this.userTextBox.Name = "userTextBox";
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            // 
            // userLabel
            // 
            resources.ApplyResources(this.userLabel, "userLabel");
            this.userLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.userLabel.Name = "userLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.passwordLabel.Name = "passwordLabel";
            // 
            // loginButton
            // 
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.Name = "loginButton";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // addUserLabel
            // 
            resources.ApplyResources(this.addUserLabel, "addUserLabel");
            this.addUserLabel.Name = "addUserLabel";
            this.addUserLabel.TabStop = true;
            this.addUserLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addUserLabel_LinkClicked);
            // 
            // LoginWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.addUserLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroTextBox userTextBox;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroLabel userLabel;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroButton loginButton;
        private System.Windows.Forms.LinkLabel addUserLabel;
    }
}