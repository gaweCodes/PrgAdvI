namespace InterfaceTask3.View
{
    partial class Main
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
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblBirthdate = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.DtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.LsbPersons = new System.Windows.Forms.ListBox();
            this.BtnCreatePerson = new System.Windows.Forms.Button();
            this.BtnGetOldestPerson = new System.Windows.Forms.Button();
            this.LblOldestPerson = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(12, 15);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(52, 13);
            this.LblFirstName.TabIndex = 0;
            this.LblFirstName.Text = "Firstname";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(12, 41);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(53, 13);
            this.LblLastName.TabIndex = 1;
            this.LblLastName.Text = "Lastname";
            // 
            // LblBirthdate
            // 
            this.LblBirthdate.AutoSize = true;
            this.LblBirthdate.Location = new System.Drawing.Point(12, 67);
            this.LblBirthdate.Name = "LblBirthdate";
            this.LblBirthdate.Size = new System.Drawing.Size(49, 13);
            this.LblBirthdate.TabIndex = 2;
            this.LblBirthdate.Text = "Birthdate";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(71, 12);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(200, 20);
            this.TxtFirstName.TabIndex = 3;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(71, 38);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(200, 20);
            this.TxtLastName.TabIndex = 4;
            // 
            // DtpBirthdate
            // 
            this.DtpBirthdate.Location = new System.Drawing.Point(71, 65);
            this.DtpBirthdate.Name = "DtpBirthdate";
            this.DtpBirthdate.Size = new System.Drawing.Size(200, 20);
            this.DtpBirthdate.TabIndex = 5;
            // 
            // LsbPersons
            // 
            this.LsbPersons.FormattingEnabled = true;
            this.LsbPersons.Location = new System.Drawing.Point(278, 13);
            this.LsbPersons.Name = "LsbPersons";
            this.LsbPersons.Size = new System.Drawing.Size(293, 173);
            this.LsbPersons.TabIndex = 6;
            // 
            // BtnCreatePerson
            // 
            this.BtnCreatePerson.Location = new System.Drawing.Point(196, 194);
            this.BtnCreatePerson.Name = "BtnCreatePerson";
            this.BtnCreatePerson.Size = new System.Drawing.Size(75, 23);
            this.BtnCreatePerson.TabIndex = 7;
            this.BtnCreatePerson.Text = "Create";
            this.BtnCreatePerson.UseVisualStyleBackColor = true;
            this.BtnCreatePerson.Click += new System.EventHandler(this.BtnCreatePerson_Click);
            // 
            // BtnGetOldestPerson
            // 
            this.BtnGetOldestPerson.Location = new System.Drawing.Point(278, 194);
            this.BtnGetOldestPerson.Name = "BtnGetOldestPerson";
            this.BtnGetOldestPerson.Size = new System.Drawing.Size(75, 23);
            this.BtnGetOldestPerson.TabIndex = 8;
            this.BtnGetOldestPerson.Text = "Oldest";
            this.BtnGetOldestPerson.UseVisualStyleBackColor = true;
            this.BtnGetOldestPerson.Click += new System.EventHandler(this.BtnGetOldestPerson_Click);
            // 
            // LblOldestPerson
            // 
            this.LblOldestPerson.AutoSize = true;
            this.LblOldestPerson.Location = new System.Drawing.Point(359, 199);
            this.LblOldestPerson.Name = "LblOldestPerson";
            this.LblOldestPerson.Size = new System.Drawing.Size(0, 13);
            this.LblOldestPerson.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 228);
            this.Controls.Add(this.LblOldestPerson);
            this.Controls.Add(this.BtnGetOldestPerson);
            this.Controls.Add(this.BtnCreatePerson);
            this.Controls.Add(this.LsbPersons);
            this.Controls.Add(this.DtpBirthdate);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.LblBirthdate);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblFirstName);
            this.Name = "Main";
            this.Text = "Person Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblBirthdate;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.DateTimePicker DtpBirthdate;
        private System.Windows.Forms.ListBox LsbPersons;
        private System.Windows.Forms.Button BtnCreatePerson;
        private System.Windows.Forms.Button BtnGetOldestPerson;
        private System.Windows.Forms.Label LblOldestPerson;
    }
}

