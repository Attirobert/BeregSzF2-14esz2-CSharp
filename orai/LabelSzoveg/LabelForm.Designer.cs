namespace LabelSzoveg
{
    partial class LabelForm
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
            this.lblFull = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFull
            // 
            this.lblFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFull.Location = new System.Drawing.Point(0, 0);
            this.lblFull.Name = "lblFull";
            this.lblFull.Size = new System.Drawing.Size(800, 450);
            this.lblFull.TabIndex = 0;
            this.lblFull.Text = "label1";
            this.lblFull.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblFull_MouseClick);
            // 
            // LabelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFull);
            this.Name = "LabelForm";
            this.Text = "Label szövg igazítás";
            this.Load += new System.EventHandler(this.LabelForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFull;
    }
}

