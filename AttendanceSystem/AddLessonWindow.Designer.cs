namespace AttendanceSystem
{
    partial class AddLessonWindow
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
            this.lessonNameLabel = new System.Windows.Forms.Label();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.lessonNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lessonNameLabel
            // 
            this.lessonNameLabel.AutoSize = true;
            this.lessonNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lessonNameLabel.Location = new System.Drawing.Point(25, 27);
            this.lessonNameLabel.Name = "lessonNameLabel";
            this.lessonNameLabel.Size = new System.Drawing.Size(129, 24);
            this.lessonNameLabel.TabIndex = 16;
            this.lessonNameLabel.Text = "Lesson name:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(163, 70);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 42);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // lessonNameTextBox
            // 
            this.lessonNameTextBox.Location = new System.Drawing.Point(163, 27);
            this.lessonNameTextBox.Name = "lessonNameTextBox";
            this.lessonNameTextBox.Size = new System.Drawing.Size(231, 23);
            this.lessonNameTextBox.TabIndex = 14;
            // 
            // AddLessonWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 137);
            this.Controls.Add(this.lessonNameLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.lessonNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddLessonWindow";
            this.Text = "Add lesson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lessonNameLabel;
        private MetroFramework.Controls.MetroButton addButton;
        private MetroFramework.Controls.MetroTextBox lessonNameTextBox;
    }
}