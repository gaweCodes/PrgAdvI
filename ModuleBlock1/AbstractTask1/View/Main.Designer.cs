namespace AbstractTask1.View
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
            this.BtnShowCompactDiscs = new System.Windows.Forms.Button();
            this.LsbCompactDiscs = new System.Windows.Forms.ListBox();
            this.BtnShowDigitalVideoDiscs = new System.Windows.Forms.Button();
            this.LsbDigitalVideoDiscs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnShowCompactDiscs
            // 
            this.BtnShowCompactDiscs.Location = new System.Drawing.Point(13, 13);
            this.BtnShowCompactDiscs.Name = "BtnShowCompactDiscs";
            this.BtnShowCompactDiscs.Size = new System.Drawing.Size(124, 23);
            this.BtnShowCompactDiscs.TabIndex = 0;
            this.BtnShowCompactDiscs.Text = "Show CDs";
            this.BtnShowCompactDiscs.UseVisualStyleBackColor = true;
            this.BtnShowCompactDiscs.Click += new System.EventHandler(this.BtnShowCompactDiscs_Click);
            // 
            // LsbCompactDiscs
            // 
            this.LsbCompactDiscs.FormattingEnabled = true;
            this.LsbCompactDiscs.ItemHeight = 16;
            this.LsbCompactDiscs.Location = new System.Drawing.Point(143, 13);
            this.LsbCompactDiscs.Name = "LsbCompactDiscs";
            this.LsbCompactDiscs.Size = new System.Drawing.Size(1039, 148);
            this.LsbCompactDiscs.TabIndex = 1;
            // 
            // BtnShowDigitalVideoDiscs
            // 
            this.BtnShowDigitalVideoDiscs.Location = new System.Drawing.Point(13, 171);
            this.BtnShowDigitalVideoDiscs.Name = "BtnShowDigitalVideoDiscs";
            this.BtnShowDigitalVideoDiscs.Size = new System.Drawing.Size(124, 23);
            this.BtnShowDigitalVideoDiscs.TabIndex = 2;
            this.BtnShowDigitalVideoDiscs.Text = "Show DVDs";
            this.BtnShowDigitalVideoDiscs.UseVisualStyleBackColor = true;
            this.BtnShowDigitalVideoDiscs.Click += new System.EventHandler(this.BtnShowDigitalVideoDiscs_Click);
            // 
            // LsbDigitalVideoDiscs
            // 
            this.LsbDigitalVideoDiscs.FormattingEnabled = true;
            this.LsbDigitalVideoDiscs.ItemHeight = 16;
            this.LsbDigitalVideoDiscs.Location = new System.Drawing.Point(143, 171);
            this.LsbDigitalVideoDiscs.Name = "LsbDigitalVideoDiscs";
            this.LsbDigitalVideoDiscs.Size = new System.Drawing.Size(1039, 148);
            this.LsbDigitalVideoDiscs.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 331);
            this.Controls.Add(this.LsbDigitalVideoDiscs);
            this.Controls.Add(this.BtnShowDigitalVideoDiscs);
            this.Controls.Add(this.LsbCompactDiscs);
            this.Controls.Add(this.BtnShowCompactDiscs);
            this.Name = "Main";
            this.Text = "Medium Collection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShowCompactDiscs;
        private System.Windows.Forms.ListBox LsbCompactDiscs;
        private System.Windows.Forms.Button BtnShowDigitalVideoDiscs;
        private System.Windows.Forms.ListBox LsbDigitalVideoDiscs;
    }
}

