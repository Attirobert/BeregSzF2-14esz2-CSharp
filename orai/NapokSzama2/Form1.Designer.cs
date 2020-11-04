namespace NapokSzama2
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
            this.mcKezdo = new System.Windows.Forms.MonthCalendar();
            this.mcZaro = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEredm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mcKezdo
            // 
            this.mcKezdo.Location = new System.Drawing.Point(102, 105);
            this.mcKezdo.Name = "mcKezdo";
            this.mcKezdo.TabIndex = 0;
            this.mcKezdo.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Szamit);
            // 
            // mcZaro
            // 
            this.mcZaro.Location = new System.Drawing.Point(373, 105);
            this.mcZaro.Name = "mcZaro";
            this.mcZaro.TabIndex = 1;
            this.mcZaro.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Szamit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kezdő dátum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Záró dátum";
            // 
            // lblEredm
            // 
            this.lblEredm.AutoSize = true;
            this.lblEredm.Location = new System.Drawing.Point(202, 311);
            this.lblEredm.Name = "lblEredm";
            this.lblEredm.Size = new System.Drawing.Size(102, 13);
            this.lblEredm.TabIndex = 4;
            this.lblEredm.Text = "Eltelt napok száma: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEredm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mcZaro);
            this.Controls.Add(this.mcKezdo);
            this.Name = "Form1";
            this.Text = "Napok száma 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcKezdo;
        private System.Windows.Forms.MonthCalendar mcZaro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEredm;
    }
}

