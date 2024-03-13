
namespace PersonUI
{
    partial class HomePage
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.PersonGridView = new System.Windows.Forms.DataGridView();
            this.PersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonDetailsBox = new System.Windows.Forms.GroupBox();
            this.PersonAppLabel = new System.Windows.Forms.Label();
            this.ViewPersonButton = new System.Windows.Forms.Button();
            this.EditPersonButton = new System.Windows.Forms.Button();
            this.DeletePersonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridView)).BeginInit();
            this.PersonDetailsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(478, 347);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(79, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPersonButton.Location = new System.Drawing.Point(74, 347);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(79, 23);
            this.AddPersonButton.TabIndex = 6;
            this.AddPersonButton.Text = "Add Person";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // PersonGridView
            // 
            this.PersonGridView.AllowUserToAddRows = false;
            this.PersonGridView.AllowUserToDeleteRows = false;
            this.PersonGridView.AllowUserToOrderColumns = true;
            this.PersonGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonGridView.CausesValidation = false;
            this.PersonGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonId,
            this.FullName,
            this.EmailAddressColumn,
            this.DateOfBirthColumn,
            this.GenderColumn});
            this.PersonGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.PersonGridView.Location = new System.Drawing.Point(20, 31);
            this.PersonGridView.Name = "PersonGridView";
            this.PersonGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PersonGridView.Size = new System.Drawing.Size(491, 177);
            this.PersonGridView.TabIndex = 8;
            // 
            // PersonId
            // 
            this.PersonId.DataPropertyName = "PersonId";
            this.PersonId.HeaderText = "Id";
            this.PersonId.Name = "PersonId";
            this.PersonId.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            // 
            // EmailAddressColumn
            // 
            this.EmailAddressColumn.DataPropertyName = "EmailAddress";
            this.EmailAddressColumn.HeaderText = "Email";
            this.EmailAddressColumn.Name = "EmailAddressColumn";
            this.EmailAddressColumn.ReadOnly = true;
            // 
            // DateOfBirthColumn
            // 
            this.DateOfBirthColumn.DataPropertyName = "DateOfBirth";
            this.DateOfBirthColumn.HeaderText = "Date of Birth";
            this.DateOfBirthColumn.Name = "DateOfBirthColumn";
            this.DateOfBirthColumn.ReadOnly = true;
            this.DateOfBirthColumn.Width = 112;
            // 
            // GenderColumn
            // 
            this.GenderColumn.DataPropertyName = "Gender";
            this.GenderColumn.HeaderText = "Gender";
            this.GenderColumn.Name = "GenderColumn";
            this.GenderColumn.ReadOnly = true;
            this.GenderColumn.Width = 79;
            // 
            // PersonDetailsBox
            // 
            this.PersonDetailsBox.Controls.Add(this.PersonGridView);
            this.PersonDetailsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonDetailsBox.Location = new System.Drawing.Point(27, 91);
            this.PersonDetailsBox.Name = "PersonDetailsBox";
            this.PersonDetailsBox.Size = new System.Drawing.Size(532, 224);
            this.PersonDetailsBox.TabIndex = 9;
            this.PersonDetailsBox.TabStop = false;
            this.PersonDetailsBox.Text = "Persons Details";
            // 
            // PersonAppLabel
            // 
            this.PersonAppLabel.AutoSize = true;
            this.PersonAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonAppLabel.Location = new System.Drawing.Point(29, 19);
            this.PersonAppLabel.Name = "PersonAppLabel";
            this.PersonAppLabel.Size = new System.Drawing.Size(95, 13);
            this.PersonAppLabel.TabIndex = 10;
            this.PersonAppLabel.Text = "Person Application";
            // 
            // ViewPersonButton
            // 
            this.ViewPersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPersonButton.Location = new System.Drawing.Point(173, 347);
            this.ViewPersonButton.Name = "ViewPersonButton";
            this.ViewPersonButton.Size = new System.Drawing.Size(75, 23);
            this.ViewPersonButton.TabIndex = 11;
            this.ViewPersonButton.Text = "View";
            this.ViewPersonButton.UseVisualStyleBackColor = true;
            this.ViewPersonButton.Click += new System.EventHandler(this.ViewPersonButton_Click);
            // 
            // EditPersonButton
            // 
            this.EditPersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPersonButton.Location = new System.Drawing.Point(254, 347);
            this.EditPersonButton.Name = "EditPersonButton";
            this.EditPersonButton.Size = new System.Drawing.Size(75, 23);
            this.EditPersonButton.TabIndex = 11;
            this.EditPersonButton.Text = "Edit";
            this.EditPersonButton.UseVisualStyleBackColor = true;
            this.EditPersonButton.Click += new System.EventHandler(this.EditPersonButton_Click);
            // 
            // DeletePersonButton
            // 
            this.DeletePersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePersonButton.Location = new System.Drawing.Point(335, 347);
            this.DeletePersonButton.Name = "DeletePersonButton";
            this.DeletePersonButton.Size = new System.Drawing.Size(75, 23);
            this.DeletePersonButton.TabIndex = 11;
            this.DeletePersonButton.Text = "Delete";
            this.DeletePersonButton.UseVisualStyleBackColor = true;
            this.DeletePersonButton.Click += new System.EventHandler(this.DeletePersonButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 382);
            this.Controls.Add(this.DeletePersonButton);
            this.Controls.Add(this.EditPersonButton);
            this.Controls.Add(this.ViewPersonButton);
            this.Controls.Add(this.PersonAppLabel);
            this.Controls.Add(this.PersonDetailsBox);
            this.Controls.Add(this.AddPersonButton);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePage_Loaded);
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridView)).EndInit();
            this.PersonDetailsBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.DataGridView PersonGridView;
        private System.Windows.Forms.GroupBox PersonDetailsBox;
        private System.Windows.Forms.Label PersonAppLabel;
        private System.Windows.Forms.Button ViewPersonButton;
        private System.Windows.Forms.Button EditPersonButton;
        private System.Windows.Forms.Button DeletePersonButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderColumn;
    }
}