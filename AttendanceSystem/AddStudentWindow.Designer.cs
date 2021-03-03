namespace AttendanceSystem
{
    partial class AddStudentWindow
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
            this.studentFirstNameLabel = new MetroFramework.Controls.MetroLabel();
            this.studentFirstNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.studentLastNameLabel = new MetroFramework.Controls.MetroLabel();
            this.studentLastNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.studentPatronymicLabel = new MetroFramework.Controls.MetroLabel();
            this.studentPatronymicTextBox = new MetroFramework.Controls.MetroTextBox();
            this.cardIdLabel = new MetroFramework.Controls.MetroLabel();
            this.cardIdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.groupsComboBox = new System.Windows.Forms.ComboBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.optionalDataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentFirstNameLabel
            // 
            this.studentFirstNameLabel.AutoSize = true;
            this.studentFirstNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.studentFirstNameLabel.Location = new System.Drawing.Point(11, 37);
            this.studentFirstNameLabel.Name = "studentFirstNameLabel";
            this.studentFirstNameLabel.Size = new System.Drawing.Size(98, 25);
            this.studentFirstNameLabel.TabIndex = 9;
            this.studentFirstNameLabel.Text = "First name:";
            // 
            // studentFirstNameTextBox
            // 
            this.studentFirstNameTextBox.Location = new System.Drawing.Point(116, 37);
            this.studentFirstNameTextBox.Name = "studentFirstNameTextBox";
            this.studentFirstNameTextBox.Size = new System.Drawing.Size(231, 24);
            this.studentFirstNameTextBox.TabIndex = 8;
            // 
            // studentLastNameLabel
            // 
            this.studentLastNameLabel.AutoSize = true;
            this.studentLastNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.studentLastNameLabel.Location = new System.Drawing.Point(12, 77);
            this.studentLastNameLabel.Name = "studentLastNameLabel";
            this.studentLastNameLabel.Size = new System.Drawing.Size(97, 25);
            this.studentLastNameLabel.TabIndex = 11;
            this.studentLastNameLabel.Text = "Last name:";
            // 
            // studentLastNameTextBox
            // 
            this.studentLastNameTextBox.Location = new System.Drawing.Point(116, 78);
            this.studentLastNameTextBox.Name = "studentLastNameTextBox";
            this.studentLastNameTextBox.Size = new System.Drawing.Size(231, 24);
            this.studentLastNameTextBox.TabIndex = 10;
            // 
            // studentPatronymicLabel
            // 
            this.studentPatronymicLabel.AutoSize = true;
            this.studentPatronymicLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.studentPatronymicLabel.Location = new System.Drawing.Point(-2, 115);
            this.studentPatronymicLabel.Name = "studentPatronymicLabel";
            this.studentPatronymicLabel.Size = new System.Drawing.Size(112, 25);
            this.studentPatronymicLabel.TabIndex = 13;
            this.studentPatronymicLabel.Text = "*Patronymic:";
            // 
            // studentPatronymicTextBox
            // 
            this.studentPatronymicTextBox.Location = new System.Drawing.Point(116, 116);
            this.studentPatronymicTextBox.Name = "studentPatronymicTextBox";
            this.studentPatronymicTextBox.Size = new System.Drawing.Size(231, 24);
            this.studentPatronymicTextBox.TabIndex = 12;
            // 
            // cardIdLabel
            // 
            this.cardIdLabel.AutoSize = true;
            this.cardIdLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.cardIdLabel.Location = new System.Drawing.Point(12, 155);
            this.cardIdLabel.Name = "cardIdLabel";
            this.cardIdLabel.Size = new System.Drawing.Size(79, 25);
            this.cardIdLabel.TabIndex = 15;
            this.cardIdLabel.Text = "Card id: ";
            // 
            // cardIdTextBox
            // 
            this.cardIdTextBox.Location = new System.Drawing.Point(116, 155);
            this.cardIdTextBox.Name = "cardIdTextBox";
            this.cardIdTextBox.Size = new System.Drawing.Size(231, 24);
            this.cardIdTextBox.TabIndex = 14;
            // 
            // groupsComboBox
            // 
            this.groupsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupsComboBox.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsComboBox.FormattingEnabled = true;
            this.groupsComboBox.Location = new System.Drawing.Point(116, 196);
            this.groupsComboBox.Name = "groupsComboBox";
            this.groupsComboBox.Size = new System.Drawing.Size(231, 28);
            this.groupsComboBox.TabIndex = 16;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupLabel.Location = new System.Drawing.Point(12, 195);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(69, 25);
            this.groupLabel.TabIndex = 17;
            this.groupLabel.Text = "Group:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(101, 259);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(153, 28);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // optionalDataLabel
            // 
            this.optionalDataLabel.AutoSize = true;
            this.optionalDataLabel.Location = new System.Drawing.Point(237, 9);
            this.optionalDataLabel.Name = "optionalDataLabel";
            this.optionalDataLabel.Size = new System.Drawing.Size(119, 19);
            this.optionalDataLabel.TabIndex = 19;
            this.optionalDataLabel.Text = "* - optional data";
            // 
            // AddStudentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(368, 314);
            this.Controls.Add(this.optionalDataLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.groupsComboBox);
            this.Controls.Add(this.cardIdLabel);
            this.Controls.Add(this.cardIdTextBox);
            this.Controls.Add(this.studentPatronymicLabel);
            this.Controls.Add(this.studentPatronymicTextBox);
            this.Controls.Add(this.studentLastNameLabel);
            this.Controls.Add(this.studentLastNameTextBox);
            this.Controls.Add(this.studentFirstNameLabel);
            this.Controls.Add(this.studentFirstNameTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudentWindow";
            this.Text = "Add  student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel studentFirstNameLabel;
        private MetroFramework.Controls.MetroTextBox studentFirstNameTextBox;
        private MetroFramework.Controls.MetroLabel studentLastNameLabel;
        private MetroFramework.Controls.MetroTextBox studentLastNameTextBox;
        private MetroFramework.Controls.MetroLabel studentPatronymicLabel;
        private MetroFramework.Controls.MetroTextBox studentPatronymicTextBox;
        private MetroFramework.Controls.MetroLabel cardIdLabel;
        private MetroFramework.Controls.MetroTextBox cardIdTextBox;
        private System.Windows.Forms.ComboBox groupsComboBox;
        private System.Windows.Forms.Label groupLabel;
        private MetroFramework.Controls.MetroButton addButton;
        private System.Windows.Forms.Label optionalDataLabel;
    }
}