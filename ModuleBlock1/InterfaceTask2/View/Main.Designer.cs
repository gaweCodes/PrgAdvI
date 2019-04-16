namespace InterfaceTask2.View
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
            this.LsbPersons = new System.Windows.Forms.ListBox();
            this.BtnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LsbPersons
            // 
            this.LsbPersons.FormattingEnabled = true;
            this.LsbPersons.ItemHeight = 16;
            this.LsbPersons.Location = new System.Drawing.Point(17, 16);
            this.LsbPersons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LsbPersons.Name = "LsbPersons";
            this.LsbPersons.Size = new System.Drawing.Size(605, 516);
            this.LsbPersons.TabIndex = 0;
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(17, 542);
            this.BtnSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(607, 28);
            this.BtnSort.TabIndex = 1;
            this.BtnSort.Text = "Sort";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 582);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.LsbPersons);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Sort Persons";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LsbPersons;
        private System.Windows.Forms.Button BtnSort;
    }
}

