namespace AttendanceSystem
{
    partial class AddTeacherWindow
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
            this.lastNameLabel = new MetroFramework.Controls.MetroLabel();
            this.firstNameLabel = new MetroFramework.Controls.MetroLabel();
            this.lastNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.firstNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.patronymicLabel = new MetroFramework.Controls.MetroLabel();
            this.patronymicTextBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.statusLabel = new MetroFramework.Controls.MetroLabel();
            this.statusesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lastNameLabel.Location = new System.Drawing.Point(13, 52);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(97, 25);
            this.lastNameLabel.TabIndex = 8;
            this.lastNameLabel.Text = "Last name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 9);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(98, 25);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "First name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(140, 54);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PasswordChar = '*';
            this.lastNameTextBox.Size = new System.Drawing.Size(231, 23);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(140, 15);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(231, 23);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(140, 258);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(115, 42);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.patronymicLabel.Location = new System.Drawing.Point(13, 93);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(104, 25);
            this.patronymicLabel.TabIndex = 11;
            this.patronymicLabel.Text = "Patronymic:";
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(140, 95);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.PasswordChar = '*';
            this.patronymicTextBox.Size = new System.Drawing.Size(231, 23);
            this.patronymicTextBox.TabIndex = 10;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.passwordLabel.Location = new System.Drawing.Point(13, 141);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(89, 25);
            this.passwordLabel.TabIndex = 13;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(140, 141);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(231, 23);
            this.passwordTextBox.TabIndex = 12;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.statusLabel.Location = new System.Drawing.Point(13, 194);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(63, 25);
            this.statusLabel.TabIndex = 15;
            this.statusLabel.Text = "Status:";
            // 
            // statusesComboBox
            // 
            this.statusesComboBox.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusesComboBox.FormattingEnabled = true;
            this.statusesComboBox.Location = new System.Drawing.Point(140, 194);
            this.statusesComboBox.Name = "statusesComboBox";
            this.statusesComboBox.Size = new System.Drawing.Size(231, 28);
            this.statusesComboBox.TabIndex = 16;
            // 
            // AddTeacherWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(411, 322);
            this.Controls.Add(this.statusesComboBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.patronymicLabel);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTeacherWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lastNameLabel;
        private MetroFramework.Controls.MetroLabel firstNameLabel;
        private MetroFramework.Controls.MetroTextBox lastNameTextBox;
        private MetroFramework.Controls.MetroTextBox firstNameTextBox;
        private MetroFramework.Controls.MetroButton addButton;
        private MetroFramework.Controls.MetroLabel patronymicLabel;
        private MetroFramework.Controls.MetroTextBox patronymicTextBox;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroLabel statusLabel;
        private System.Windows.Forms.ComboBox statusesComboBox;
    }
}