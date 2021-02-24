namespace AttendanceSystem
{
    partial class AddGroupWindow
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
            this.groupNameLabel = new MetroFramework.Controls.MetroLabel();
            this.userNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.curatorLabel = new MetroFramework.Controls.MetroLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.groupNameLabel.Location = new System.Drawing.Point(12, 31);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(117, 25);
            this.groupNameLabel.TabIndex = 9;
            this.groupNameLabel.Text = "Group name:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(135, 33);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(231, 23);
            this.userNameTextBox.TabIndex = 8;
            // 
            // curatorLabel
            // 
            this.curatorLabel.AutoSize = true;
            this.curatorLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.curatorLabel.Location = new System.Drawing.Point(12, 83);
            this.curatorLabel.Name = "curatorLabel";
            this.curatorLabel.Size = new System.Drawing.Size(77, 25);
            this.curatorLabel.TabIndex = 10;
            this.curatorLabel.Text = "Curator:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(135, 130);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 42);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            // 
            // AddGroupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(394, 184);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.curatorLabel);
            this.Controls.Add(this.groupNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGroupWindow";
            this.Text = "Add group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel groupNameLabel;
        private MetroFramework.Controls.MetroTextBox userNameTextBox;
        private MetroFramework.Controls.MetroLabel curatorLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private MetroFramework.Controls.MetroButton addButton;
    }
}