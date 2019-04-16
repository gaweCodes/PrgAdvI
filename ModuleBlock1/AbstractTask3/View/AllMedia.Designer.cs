namespace AbstractTask3.View
{
    partial class AllMedia
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
            this.BtnShowMediums = new System.Windows.Forms.Button();
            this.LsbAllMediums = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnShowMediums
            // 
            this.BtnShowMediums.Location = new System.Drawing.Point(13, 13);
            this.BtnShowMediums.Name = "BtnShowMediums";
            this.BtnShowMediums.Size = new System.Drawing.Size(124, 23);
            this.BtnShowMediums.TabIndex = 0;
            this.BtnShowMediums.Text = "Show all Media";
            this.BtnShowMediums.UseVisualStyleBackColor = true;
            this.BtnShowMediums.Click += new System.EventHandler(this.BtnShowAllMedium_Click);
            // 
            // LsbAllMediums
            // 
            this.LsbAllMediums.FormattingEnabled = true;
            this.LsbAllMediums.ItemHeight = 16;
            this.LsbAllMediums.Location = new System.Drawing.Point(143, 13);
            this.LsbAllMediums.Name = "LsbAllMediums";
            this.LsbAllMediums.Size = new System.Drawing.Size(1039, 308);
            this.LsbAllMediums.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 331);
            this.Controls.Add(this.LsbAllMediums);
            this.Controls.Add(this.BtnShowMediums);
            this.Name = "Main";
            this.Text = "Medium Collection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShowMediums;
        private System.Windows.Forms.ListBox LsbAllMediums;
    }
}

