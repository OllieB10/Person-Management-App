
namespace PersonUI
{
    partial class NewPerson
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
            this.NewPersonEntryLabel = new System.Windows.Forms.Label();
            this.ExitButtonEntry = new System.Windows.Forms.Button();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.DateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.NameGroupBox = new System.Windows.Forms.GroupBox();
            this.GenderGroupBox = new System.Windows.Forms.GroupBox();
            this.OtherRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameEntryTextbox = new System.Windows.Forms.TextBox();
            this.LastNameEntryTextbox = new System.Windows.Forms.TextBox();
            this.EmailAddressGroupbox = new System.Windows.Forms.GroupBox();
            this.EmailAddressTextbox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameGroupBox.SuspendLayout();
            this.GenderGroupBox.SuspendLayout();
            this.EmailAddressGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewPersonEntryLabel
            // 
            this.NewPersonEntryLabel.AutoSize = true;
            this.NewPersonEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPersonEntryLabel.Location = new System.Drawing.Point(33, 34);
            this.NewPersonEntryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewPersonEntryLabel.Name = "NewPersonEntryLabel";
            this.NewPersonEntryLabel.Size = new System.Drawing.Size(144, 18);
            this.NewPersonEntryLabel.TabIndex = 0;
            this.NewPersonEntryLabel.Text = "New Person Entry";
            // 
            // ExitButtonEntry
            // 
            this.ExitButtonEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButtonEntry.Location = new System.Drawing.Point(28, 500);
            this.ExitButtonEntry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButtonEntry.Name = "ExitButtonEntry";
            this.ExitButtonEntry.Size = new System.Drawing.Size(118, 35);
            this.ExitButtonEntry.TabIndex = 13;
            this.ExitButtonEntry.Text = "Exit";
            this.ExitButtonEntry.UseVisualStyleBackColor = true;
            this.ExitButtonEntry.Click += new System.EventHandler(this.ExitButtonEntry_Click);
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthLabel.Location = new System.Drawing.Point(30, 206);
            this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(81, 13);
            this.DateOfBirthLabel.TabIndex = 0;
            this.DateOfBirthLabel.Text = "Date Of Birth";
            // 
            // DateOfBirthPicker
            // 
            this.DateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfBirthPicker.Location = new System.Drawing.Point(178, 206);
            this.DateOfBirthPicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateOfBirthPicker.Name = "DateOfBirthPicker";
            this.DateOfBirthPicker.Size = new System.Drawing.Size(148, 20);
            this.DateOfBirthPicker.TabIndex = 14;
            // 
            // NameGroupBox
            // 
            this.NameGroupBox.Controls.Add(this.DateOfBirthPicker);
            this.NameGroupBox.Controls.Add(this.GenderGroupBox);
            this.NameGroupBox.Controls.Add(this.FirstNameLabel);
            this.NameGroupBox.Controls.Add(this.LastNameLabel);
            this.NameGroupBox.Controls.Add(this.FirstNameEntryTextbox);
            this.NameGroupBox.Controls.Add(this.DateOfBirthLabel);
            this.NameGroupBox.Controls.Add(this.LastNameEntryTextbox);
            this.NameGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameGroupBox.Location = new System.Drawing.Point(28, 126);
            this.NameGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameGroupBox.Name = "NameGroupBox";
            this.NameGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameGroupBox.Size = new System.Drawing.Size(510, 270);
            this.NameGroupBox.TabIndex = 16;
            this.NameGroupBox.TabStop = false;
            this.NameGroupBox.Text = "Name";
            // 
            // GenderGroupBox
            // 
            this.GenderGroupBox.Controls.Add(this.OtherRadioButton);
            this.GenderGroupBox.Controls.Add(this.FemaleRadioButton);
            this.GenderGroupBox.Controls.Add(this.MaleRadioButton);
            this.GenderGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderGroupBox.Location = new System.Drawing.Point(33, 112);
            this.GenderGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenderGroupBox.Name = "GenderGroupBox";
            this.GenderGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenderGroupBox.Size = new System.Drawing.Size(404, 74);
            this.GenderGroupBox.TabIndex = 17;
            this.GenderGroupBox.TabStop = false;
            this.GenderGroupBox.Text = "Gender";
            // 
            // OtherRadioButton
            // 
            this.OtherRadioButton.AutoSize = true;
            this.OtherRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherRadioButton.Location = new System.Drawing.Point(261, 23);
            this.OtherRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OtherRadioButton.Name = "OtherRadioButton";
            this.OtherRadioButton.Size = new System.Drawing.Size(51, 17);
            this.OtherRadioButton.TabIndex = 0;
            this.OtherRadioButton.TabStop = true;
            this.OtherRadioButton.Text = "Other";
            this.OtherRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleRadioButton.Location = new System.Drawing.Point(141, 23);
            this.FemaleRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleRadioButton.TabIndex = 0;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleRadioButton.Location = new System.Drawing.Point(27, 23);
            this.MaleRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.MaleRadioButton.TabIndex = 0;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(30, 31);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(28, 72);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameEntryTextbox
            // 
            this.FirstNameEntryTextbox.BackColor = System.Drawing.Color.Ivory;
            this.FirstNameEntryTextbox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FirstNameEntryTextbox.Location = new System.Drawing.Point(112, 28);
            this.FirstNameEntryTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstNameEntryTextbox.Name = "FirstNameEntryTextbox";
            this.FirstNameEntryTextbox.Size = new System.Drawing.Size(148, 20);
            this.FirstNameEntryTextbox.TabIndex = 1;
            // 
            // LastNameEntryTextbox
            // 
            this.LastNameEntryTextbox.BackColor = System.Drawing.Color.Ivory;
            this.LastNameEntryTextbox.Location = new System.Drawing.Point(112, 72);
            this.LastNameEntryTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastNameEntryTextbox.Name = "LastNameEntryTextbox";
            this.LastNameEntryTextbox.Size = new System.Drawing.Size(148, 20);
            this.LastNameEntryTextbox.TabIndex = 2;
            // 
            // EmailAddressGroupbox
            // 
            this.EmailAddressGroupbox.Controls.Add(this.EmailAddressTextbox);
            this.EmailAddressGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressGroupbox.Location = new System.Drawing.Point(28, 415);
            this.EmailAddressGroupbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailAddressGroupbox.Name = "EmailAddressGroupbox";
            this.EmailAddressGroupbox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailAddressGroupbox.Size = new System.Drawing.Size(510, 75);
            this.EmailAddressGroupbox.TabIndex = 17;
            this.EmailAddressGroupbox.TabStop = false;
            this.EmailAddressGroupbox.Text = "Email Address";
            // 
            // EmailAddressTextbox
            // 
            this.EmailAddressTextbox.Location = new System.Drawing.Point(9, 29);
            this.EmailAddressTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailAddressTextbox.Name = "EmailAddressTextbox";
            this.EmailAddressTextbox.Size = new System.Drawing.Size(490, 20);
            this.EmailAddressTextbox.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(426, 511);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 35);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 560);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EmailAddressGroupbox);
            this.Controls.Add(this.NameGroupBox);
            this.Controls.Add(this.ExitButtonEntry);
            this.Controls.Add(this.NewPersonEntryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Person Entry";
            this.NameGroupBox.ResumeLayout(false);
            this.NameGroupBox.PerformLayout();
            this.GenderGroupBox.ResumeLayout(false);
            this.GenderGroupBox.PerformLayout();
            this.EmailAddressGroupbox.ResumeLayout(false);
            this.EmailAddressGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NewPersonEntryLabel;
        private System.Windows.Forms.Button ExitButtonEntry;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.DateTimePicker DateOfBirthPicker;
        private System.Windows.Forms.GroupBox NameGroupBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameEntryTextbox;
        private System.Windows.Forms.TextBox LastNameEntryTextbox;
        private System.Windows.Forms.GroupBox GenderGroupBox;
        private System.Windows.Forms.RadioButton OtherRadioButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.GroupBox EmailAddressGroupbox;
        private System.Windows.Forms.TextBox EmailAddressTextbox;
        private System.Windows.Forms.Button SaveButton;
    }
}