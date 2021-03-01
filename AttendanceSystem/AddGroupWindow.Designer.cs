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
            this.groupNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.curatorsComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.curatorsCheckBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Location = new System.Drawing.Point(151, 33);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(231, 23);
            this.groupNameTextBox.TabIndex = 8;
            // 
            // curatorsComboBox
            // 
            this.curatorsComboBox.FormattingEnabled = true;
            this.curatorsComboBox.Location = new System.Drawing.Point(151, 83);
            this.curatorsComboBox.Name = "curatorsComboBox";
            this.curatorsComboBox.Size = new System.Drawing.Size(231, 24);
            this.curatorsComboBox.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(135, 130);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 42);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupNameLabel.Location = new System.Drawing.Point(13, 33);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(121, 24);
            this.groupNameLabel.TabIndex = 13;
            this.groupNameLabel.Text = "Group name:";
            // 
            // curatorsCheckBox
            // 
            this.curatorsCheckBox.AutoSize = true;
            this.curatorsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curatorsCheckBox.Location = new System.Drawing.Point(13, 81);
            this.curatorsCheckBox.Name = "curatorsCheckBox";
            this.curatorsCheckBox.Size = new System.Drawing.Size(76, 24);
            this.curatorsCheckBox.TabIndex = 14;
            this.curatorsCheckBox.Text = "Curator:";
            // 
            // AddGroupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(394, 184);
            this.Controls.Add(this.curatorsCheckBox);
            this.Controls.Add(this.groupNameLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.curatorsComboBox);
            this.Controls.Add(this.groupNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGroupWindow";
            this.Text = "Add group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox groupNameTextBox;
        private System.Windows.Forms.ComboBox curatorsComboBox;
        private MetroFramework.Controls.MetroButton addButton;
        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.Label curatorsCheckBox;
    }
}