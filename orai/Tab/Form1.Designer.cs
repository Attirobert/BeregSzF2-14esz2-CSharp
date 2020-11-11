namespace Tab
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
            this.tbcElso = new System.Windows.Forms.TabControl();
            this.tbpSzemadatok = new System.Windows.Forms.TabPage();
            this.tbpKodok = new System.Windows.Forms.TabPage();
            this.tbxVezNev = new System.Windows.Forms.TextBox();
            this.tbxKeresztnev = new System.Windows.Forms.TextBox();
            this.tbxVaros = new System.Windows.Forms.TextBox();
            this.tbxLakcim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOkSza = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMegse = new System.Windows.Forms.Button();
            this.btnOkAzon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxSzemSzam = new System.Windows.Forms.TextBox();
            this.tbxAdoszam = new System.Windows.Forms.TextBox();
            this.tbxJogositvany = new System.Windows.Forms.TextBox();
            this.tbxUtlevel = new System.Windows.Forms.TextBox();
            this.tbpEredm = new System.Windows.Forms.TabPage();
            this.lblEredm = new System.Windows.Forms.Label();
            this.btnLista = new System.Windows.Forms.Button();
            this.tbcElso.SuspendLayout();
            this.tbpSzemadatok.SuspendLayout();
            this.tbpKodok.SuspendLayout();
            this.tbpEredm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcElso
            // 
            this.tbcElso.Controls.Add(this.tbpSzemadatok);
            this.tbcElso.Controls.Add(this.tbpKodok);
            this.tbcElso.Controls.Add(this.tbpEredm);
            this.tbcElso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcElso.Location = new System.Drawing.Point(0, 0);
            this.tbcElso.Name = "tbcElso";
            this.tbcElso.SelectedIndex = 0;
            this.tbcElso.Size = new System.Drawing.Size(462, 450);
            this.tbcElso.TabIndex = 0;
            // 
            // tbpSzemadatok
            // 
            this.tbpSzemadatok.Controls.Add(this.btnCancel);
            this.tbpSzemadatok.Controls.Add(this.btnOkSza);
            this.tbpSzemadatok.Controls.Add(this.label4);
            this.tbpSzemadatok.Controls.Add(this.label3);
            this.tbpSzemadatok.Controls.Add(this.label2);
            this.tbpSzemadatok.Controls.Add(this.label1);
            this.tbpSzemadatok.Controls.Add(this.tbxLakcim);
            this.tbpSzemadatok.Controls.Add(this.tbxVaros);
            this.tbpSzemadatok.Controls.Add(this.tbxKeresztnev);
            this.tbpSzemadatok.Controls.Add(this.tbxVezNev);
            this.tbpSzemadatok.Location = new System.Drawing.Point(4, 22);
            this.tbpSzemadatok.Name = "tbpSzemadatok";
            this.tbpSzemadatok.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSzemadatok.Size = new System.Drawing.Size(454, 424);
            this.tbpSzemadatok.TabIndex = 0;
            this.tbpSzemadatok.Text = "Személyi adatok";
            this.tbpSzemadatok.UseVisualStyleBackColor = true;
            // 
            // tbpKodok
            // 
            this.tbpKodok.Controls.Add(this.tbxUtlevel);
            this.tbpKodok.Controls.Add(this.tbxJogositvany);
            this.tbpKodok.Controls.Add(this.tbxAdoszam);
            this.tbpKodok.Controls.Add(this.tbxSzemSzam);
            this.tbpKodok.Controls.Add(this.label8);
            this.tbpKodok.Controls.Add(this.label7);
            this.tbpKodok.Controls.Add(this.label6);
            this.tbpKodok.Controls.Add(this.label5);
            this.tbpKodok.Controls.Add(this.btnOkAzon);
            this.tbpKodok.Controls.Add(this.btnMegse);
            this.tbpKodok.Location = new System.Drawing.Point(4, 22);
            this.tbpKodok.Name = "tbpKodok";
            this.tbpKodok.Padding = new System.Windows.Forms.Padding(3);
            this.tbpKodok.Size = new System.Drawing.Size(454, 424);
            this.tbpKodok.TabIndex = 1;
            this.tbpKodok.Text = "Azonosítók";
            this.tbpKodok.UseVisualStyleBackColor = true;
            // 
            // tbxVezNev
            // 
            this.tbxVezNev.Location = new System.Drawing.Point(151, 44);
            this.tbxVezNev.Name = "tbxVezNev";
            this.tbxVezNev.Size = new System.Drawing.Size(100, 20);
            this.tbxVezNev.TabIndex = 0;
            // 
            // tbxKeresztnev
            // 
            this.tbxKeresztnev.Location = new System.Drawing.Point(151, 108);
            this.tbxKeresztnev.Name = "tbxKeresztnev";
            this.tbxKeresztnev.Size = new System.Drawing.Size(100, 20);
            this.tbxKeresztnev.TabIndex = 1;
            this.tbxKeresztnev.TabStop = false;
            // 
            // tbxVaros
            // 
            this.tbxVaros.Location = new System.Drawing.Point(152, 176);
            this.tbxVaros.Name = "tbxVaros";
            this.tbxVaros.Size = new System.Drawing.Size(100, 20);
            this.tbxVaros.TabIndex = 3;
            // 
            // tbxLakcim
            // 
            this.tbxLakcim.Location = new System.Drawing.Point(152, 244);
            this.tbxLakcim.Name = "tbxLakcim";
            this.tbxLakcim.Size = new System.Drawing.Size(100, 20);
            this.tbxLakcim.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vezeték név: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Keresztnév: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lakás város";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lakcím:";
            // 
            // btnOkSza
            // 
            this.btnOkSza.Location = new System.Drawing.Point(252, 320);
            this.btnOkSza.Name = "btnOkSza";
            this.btnOkSza.Size = new System.Drawing.Size(75, 23);
            this.btnOkSza.TabIndex = 8;
            this.btnOkSza.Text = "OK";
            this.btnOkSza.UseVisualStyleBackColor = true;
            this.btnOkSza.Click += new System.EventHandler(this.btnOkSza_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(50, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Mégse";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMegse
            // 
            this.btnMegse.Location = new System.Drawing.Point(38, 357);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(75, 23);
            this.btnMegse.TabIndex = 0;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = true;
            this.btnMegse.Click += new System.EventHandler(this.btnMegse_Click);
            // 
            // btnOkAzon
            // 
            this.btnOkAzon.Location = new System.Drawing.Point(182, 357);
            this.btnOkAzon.Name = "btnOkAzon";
            this.btnOkAzon.Size = new System.Drawing.Size(75, 23);
            this.btnOkAzon.TabIndex = 1;
            this.btnOkAzon.Text = "OK";
            this.btnOkAzon.UseVisualStyleBackColor = true;
            this.btnOkAzon.Click += new System.EventHandler(this.btnOkAzon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Személyi szám: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Adóazonosító: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Jogosítvány: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Útlevélszám: ";
            // 
            // tbxSzemSzam
            // 
            this.tbxSzemSzam.Location = new System.Drawing.Point(125, 58);
            this.tbxSzemSzam.Name = "tbxSzemSzam";
            this.tbxSzemSzam.Size = new System.Drawing.Size(100, 20);
            this.tbxSzemSzam.TabIndex = 6;
            // 
            // tbxAdoszam
            // 
            this.tbxAdoszam.Location = new System.Drawing.Point(125, 105);
            this.tbxAdoszam.Name = "tbxAdoszam";
            this.tbxAdoszam.Size = new System.Drawing.Size(100, 20);
            this.tbxAdoszam.TabIndex = 7;
            // 
            // tbxJogositvany
            // 
            this.tbxJogositvany.Location = new System.Drawing.Point(123, 152);
            this.tbxJogositvany.Name = "tbxJogositvany";
            this.tbxJogositvany.Size = new System.Drawing.Size(100, 20);
            this.tbxJogositvany.TabIndex = 8;
            // 
            // tbxUtlevel
            // 
            this.tbxUtlevel.Location = new System.Drawing.Point(123, 199);
            this.tbxUtlevel.Name = "tbxUtlevel";
            this.tbxUtlevel.Size = new System.Drawing.Size(100, 20);
            this.tbxUtlevel.TabIndex = 9;
            // 
            // tbpEredm
            // 
            this.tbpEredm.Controls.Add(this.btnLista);
            this.tbpEredm.Controls.Add(this.lblEredm);
            this.tbpEredm.Location = new System.Drawing.Point(4, 22);
            this.tbpEredm.Name = "tbpEredm";
            this.tbpEredm.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEredm.Size = new System.Drawing.Size(454, 424);
            this.tbpEredm.TabIndex = 2;
            this.tbpEredm.Text = "Eredmény";
            this.tbpEredm.UseVisualStyleBackColor = true;
            // 
            // lblEredm
            // 
            this.lblEredm.AutoSize = true;
            this.lblEredm.Location = new System.Drawing.Point(28, 23);
            this.lblEredm.Name = "lblEredm";
            this.lblEredm.Size = new System.Drawing.Size(35, 13);
            this.lblEredm.TabIndex = 0;
            this.lblEredm.Text = "label9";
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(161, 327);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(141, 23);
            this.btnLista.TabIndex = 1;
            this.btnLista.Text = "Eredmény listázás";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.tbcElso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbcElso.ResumeLayout(false);
            this.tbpSzemadatok.ResumeLayout(false);
            this.tbpSzemadatok.PerformLayout();
            this.tbpKodok.ResumeLayout(false);
            this.tbpKodok.PerformLayout();
            this.tbpEredm.ResumeLayout(false);
            this.tbpEredm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcElso;
        private System.Windows.Forms.TabPage tbpSzemadatok;
        private System.Windows.Forms.TabPage tbpKodok;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOkSza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxLakcim;
        private System.Windows.Forms.TextBox tbxVaros;
        private System.Windows.Forms.TextBox tbxKeresztnev;
        private System.Windows.Forms.TextBox tbxVezNev;
        private System.Windows.Forms.TextBox tbxUtlevel;
        private System.Windows.Forms.TextBox tbxJogositvany;
        private System.Windows.Forms.TextBox tbxAdoszam;
        private System.Windows.Forms.TextBox tbxSzemSzam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOkAzon;
        private System.Windows.Forms.Button btnMegse;
        private System.Windows.Forms.TabPage tbpEredm;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Label lblEredm;
    }
}

