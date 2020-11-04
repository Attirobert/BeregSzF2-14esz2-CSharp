namespace DatumIdoNoveles
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
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.mtbIdo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMenny = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTipus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEredm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMenny)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(107, 54);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 0;
            this.dtpDatum.ValueChanged += new System.EventHandler(this.Szamol);
            // 
            // mtbIdo
            // 
            this.mtbIdo.Location = new System.Drawing.Point(330, 53);
            this.mtbIdo.Mask = "00:00:00";
            this.mtbIdo.Name = "mtbIdo";
            this.mtbIdo.Size = new System.Drawing.Size(100, 20);
            this.mtbIdo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dátum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Idő";
            // 
            // nudMenny
            // 
            this.nudMenny.Location = new System.Drawing.Point(107, 126);
            this.nudMenny.Name = "nudMenny";
            this.nudMenny.Size = new System.Drawing.Size(120, 20);
            this.nudMenny.TabIndex = 4;
            this.nudMenny.ValueChanged += new System.EventHandler(this.Szamol);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Növelés";
            // 
            // cbxTipus
            // 
            this.cbxTipus.FormattingEnabled = true;
            this.cbxTipus.Items.AddRange(new object[] {
            "Év",
            "Hónap",
            "Nap",
            "Óra",
            "Perc",
            "Másodperc"});
            this.cbxTipus.Location = new System.Drawing.Point(266, 124);
            this.cbxTipus.Name = "cbxTipus";
            this.cbxTipus.Size = new System.Drawing.Size(121, 21);
            this.cbxTipus.TabIndex = 6;
            this.cbxTipus.SelectedIndexChanged += new System.EventHandler(this.Szamol);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adat típus";
            // 
            // lblEredm
            // 
            this.lblEredm.AutoSize = true;
            this.lblEredm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEredm.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblEredm.Location = new System.Drawing.Point(107, 199);
            this.lblEredm.Name = "lblEredm";
            this.lblEredm.Size = new System.Drawing.Size(101, 20);
            this.lblEredm.TabIndex = 8;
            this.lblEredm.Text = "Az új dátum: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEredm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxTipus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudMenny);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbIdo);
            this.Controls.Add(this.dtpDatum);
            this.Name = "Form1";
            this.Text = "Dátum és idő növelés";
            ((System.ComponentModel.ISupportInitialize)(this.nudMenny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.MaskedTextBox mtbIdo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMenny;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTipus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEredm;
    }
}

