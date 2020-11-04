namespace Formazas
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
            this.cbxValaszt = new System.Windows.Forms.ComboBox();
            this.nudMeret = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbSzoveg = new System.Windows.Forms.RichTextBox();
            this.btnAlkalmaz = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbComics = new System.Windows.Forms.RadioButton();
            this.rbTnr = new System.Windows.Forms.RadioButton();
            this.rbArial = new System.Windows.Forms.RadioButton();
            this.rbPiros = new System.Windows.Forms.RadioButton();
            this.rbKek = new System.Windows.Forms.RadioButton();
            this.rbZold = new System.Windows.Forms.RadioButton();
            this.rbDolt = new System.Windows.Forms.RadioButton();
            this.rbAlahuzott = new System.Windows.Forms.RadioButton();
            this.rbfelkover = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeret)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxValaszt
            // 
            this.cbxValaszt.FormattingEnabled = true;
            this.cbxValaszt.Location = new System.Drawing.Point(104, 30);
            this.cbxValaszt.Name = "cbxValaszt";
            this.cbxValaszt.Size = new System.Drawing.Size(121, 21);
            this.cbxValaszt.TabIndex = 0;
            this.cbxValaszt.SelectedIndexChanged += new System.EventHandler(this.cbxValaszt_SelectedIndexChanged);
            // 
            // nudMeret
            // 
            this.nudMeret.Location = new System.Drawing.Point(104, 79);
            this.nudMeret.Name = "nudMeret";
            this.nudMeret.Size = new System.Drawing.Size(120, 20);
            this.nudMeret.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mit választ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Font méret: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Új szöveg:";
            // 
            // rtbSzoveg
            // 
            this.rtbSzoveg.BackColor = System.Drawing.SystemColors.Control;
            this.rtbSzoveg.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rtbSzoveg.Location = new System.Drawing.Point(253, 27);
            this.rtbSzoveg.Name = "rtbSzoveg";
            this.rtbSzoveg.Size = new System.Drawing.Size(334, 96);
            this.rtbSzoveg.TabIndex = 15;
            this.rtbSzoveg.Text = "Próba";
            // 
            // btnAlkalmaz
            // 
            this.btnAlkalmaz.Location = new System.Drawing.Point(491, 158);
            this.btnAlkalmaz.Name = "btnAlkalmaz";
            this.btnAlkalmaz.Size = new System.Drawing.Size(75, 23);
            this.btnAlkalmaz.TabIndex = 16;
            this.btnAlkalmaz.Text = "Alkalmaz";
            this.btnAlkalmaz.UseVisualStyleBackColor = true;
            this.btnAlkalmaz.Click += new System.EventHandler(this.btnAlkalmaz_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbZold);
            this.groupBox1.Controls.Add(this.rbKek);
            this.groupBox1.Controls.Add(this.rbPiros);
            this.groupBox1.Location = new System.Drawing.Point(12, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 153);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szín";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbfelkover);
            this.groupBox2.Controls.Add(this.rbAlahuzott);
            this.groupBox2.Controls.Add(this.rbDolt);
            this.groupBox2.Location = new System.Drawing.Point(163, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 153);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stílus";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbComics);
            this.groupBox3.Controls.Add(this.rbTnr);
            this.groupBox3.Controls.Add(this.rbArial);
            this.groupBox3.Location = new System.Drawing.Point(311, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 153);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Font";
            // 
            // rbComics
            // 
            this.rbComics.AutoSize = true;
            this.rbComics.Location = new System.Drawing.Point(39, 113);
            this.rbComics.Name = "rbComics";
            this.rbComics.Size = new System.Drawing.Size(81, 17);
            this.rbComics.TabIndex = 13;
            this.rbComics.TabStop = true;
            this.rbComics.Text = "Comic Sans";
            this.rbComics.UseVisualStyleBackColor = true;
            // 
            // rbTnr
            // 
            this.rbTnr.AutoSize = true;
            this.rbTnr.Location = new System.Drawing.Point(39, 61);
            this.rbTnr.Name = "rbTnr";
            this.rbTnr.Size = new System.Drawing.Size(115, 17);
            this.rbTnr.TabIndex = 12;
            this.rbTnr.TabStop = true;
            this.rbTnr.Text = "Times New Roman";
            this.rbTnr.UseVisualStyleBackColor = true;
            // 
            // rbArial
            // 
            this.rbArial.AutoSize = true;
            this.rbArial.Location = new System.Drawing.Point(39, 19);
            this.rbArial.Name = "rbArial";
            this.rbArial.Size = new System.Drawing.Size(45, 17);
            this.rbArial.TabIndex = 11;
            this.rbArial.TabStop = true;
            this.rbArial.Text = "Arial";
            this.rbArial.UseVisualStyleBackColor = true;
            // 
            // rbPiros
            // 
            this.rbPiros.AutoSize = true;
            this.rbPiros.Location = new System.Drawing.Point(16, 19);
            this.rbPiros.Name = "rbPiros";
            this.rbPiros.Size = new System.Drawing.Size(48, 17);
            this.rbPiros.TabIndex = 0;
            this.rbPiros.TabStop = true;
            this.rbPiros.Text = "Piros";
            this.rbPiros.UseVisualStyleBackColor = true;
            // 
            // rbKek
            // 
            this.rbKek.AutoSize = true;
            this.rbKek.Location = new System.Drawing.Point(16, 63);
            this.rbKek.Name = "rbKek";
            this.rbKek.Size = new System.Drawing.Size(44, 17);
            this.rbKek.TabIndex = 1;
            this.rbKek.TabStop = true;
            this.rbKek.Text = "Kék";
            this.rbKek.UseVisualStyleBackColor = true;
            // 
            // rbZold
            // 
            this.rbZold.AutoSize = true;
            this.rbZold.Location = new System.Drawing.Point(16, 117);
            this.rbZold.Name = "rbZold";
            this.rbZold.Size = new System.Drawing.Size(46, 17);
            this.rbZold.TabIndex = 2;
            this.rbZold.TabStop = true;
            this.rbZold.Text = "Zöld";
            this.rbZold.UseVisualStyleBackColor = true;
            // 
            // rbDolt
            // 
            this.rbDolt.AutoSize = true;
            this.rbDolt.Location = new System.Drawing.Point(25, 23);
            this.rbDolt.Name = "rbDolt";
            this.rbDolt.Size = new System.Drawing.Size(44, 17);
            this.rbDolt.TabIndex = 11;
            this.rbDolt.TabStop = true;
            this.rbDolt.Text = "Dölt";
            this.rbDolt.UseVisualStyleBackColor = true;
            // 
            // rbAlahuzott
            // 
            this.rbAlahuzott.AutoSize = true;
            this.rbAlahuzott.Location = new System.Drawing.Point(25, 61);
            this.rbAlahuzott.Name = "rbAlahuzott";
            this.rbAlahuzott.Size = new System.Drawing.Size(69, 17);
            this.rbAlahuzott.TabIndex = 11;
            this.rbAlahuzott.TabStop = true;
            this.rbAlahuzott.Text = "Aláhúzott";
            this.rbAlahuzott.UseVisualStyleBackColor = true;
            // 
            // rbfelkover
            // 
            this.rbfelkover.AutoSize = true;
            this.rbfelkover.Location = new System.Drawing.Point(25, 113);
            this.rbfelkover.Name = "rbfelkover";
            this.rbfelkover.Size = new System.Drawing.Size(64, 17);
            this.rbfelkover.TabIndex = 11;
            this.rbfelkover.TabStop = true;
            this.rbfelkover.Text = "Fékövér";
            this.rbfelkover.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 347);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAlkalmaz);
            this.Controls.Add(this.rtbSzoveg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMeret);
            this.Controls.Add(this.cbxValaszt);
            this.Name = "Form1";
            this.Text = "Formázás";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMeret)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxValaszt;
        private System.Windows.Forms.NumericUpDown nudMeret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbSzoveg;
        private System.Windows.Forms.Button btnAlkalmaz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbComics;
        private System.Windows.Forms.RadioButton rbTnr;
        private System.Windows.Forms.RadioButton rbArial;
        private System.Windows.Forms.RadioButton rbZold;
        private System.Windows.Forms.RadioButton rbKek;
        private System.Windows.Forms.RadioButton rbPiros;
        private System.Windows.Forms.RadioButton rbfelkover;
        private System.Windows.Forms.RadioButton rbAlahuzott;
        private System.Windows.Forms.RadioButton rbDolt;
    }
}

