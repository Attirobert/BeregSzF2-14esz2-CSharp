namespace DinamKomp
{
    partial class Form1
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
            this.lblSzoveg = new System.Windows.Forms.Label();
            this.lblEredm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSzoveg
            // 
            this.lblSzoveg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSzoveg.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSzoveg.Location = new System.Drawing.Point(0, 0);
            this.lblSzoveg.Name = "lblSzoveg";
            this.lblSzoveg.Padding = new System.Windows.Forms.Padding(3);
            this.lblSzoveg.Size = new System.Drawing.Size(800, 31);
            this.lblSzoveg.TabIndex = 0;
            this.lblSzoveg.Text = "label1";
            // 
            // lblEredm
            // 
            this.lblEredm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblEredm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEredm.Location = new System.Drawing.Point(0, 31);
            this.lblEredm.Name = "lblEredm";
            this.lblEredm.Padding = new System.Windows.Forms.Padding(3);
            this.lblEredm.Size = new System.Drawing.Size(800, 29);
            this.lblEredm.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEredm);
            this.Controls.Add(this.lblSzoveg);
            this.Name = "Form1";
            this.Text = "Dinamikus komponensek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSzoveg;
        private System.Windows.Forms.Label lblEredm;
    }
}

