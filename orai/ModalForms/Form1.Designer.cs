namespace ModalForms
{
    partial class frmFo
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Józsa János",
            "jj1",
            "1956.12.03"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Kiss Gergő",
            "kg1",
            "1992.11.12"}, -1);
            this.ltvAdatok = new System.Windows.Forms.ListView();
            this.chNev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAzonosito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSzulDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFelvitel = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnFajlbol = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnModosit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltvAdatok
            // 
            this.ltvAdatok.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNev,
            this.chAzonosito,
            this.chSzulDatum});
            this.ltvAdatok.Dock = System.Windows.Forms.DockStyle.Left;
            this.ltvAdatok.GridLines = true;
            this.ltvAdatok.HideSelection = false;
            this.ltvAdatok.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.ltvAdatok.Location = new System.Drawing.Point(0, 0);
            this.ltvAdatok.Name = "ltvAdatok";
            this.ltvAdatok.Size = new System.Drawing.Size(631, 450);
            this.ltvAdatok.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ltvAdatok.TabIndex = 0;
            this.ltvAdatok.UseCompatibleStateImageBehavior = false;
            this.ltvAdatok.View = System.Windows.Forms.View.Details;
            // 
            // chNev
            // 
            this.chNev.Text = "Név";
            this.chNev.Width = 150;
            // 
            // chAzonosito
            // 
            this.chAzonosito.Text = "Azonosító";
            this.chAzonosito.Width = 100;
            // 
            // chSzulDatum
            // 
            this.chSzulDatum.Text = "Születési dátum";
            this.chSzulDatum.Width = 120;
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.Location = new System.Drawing.Point(659, 41);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(75, 23);
            this.btnFelvitel.TabIndex = 1;
            this.btnFelvitel.Text = "Felvitel";
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(659, 149);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(75, 23);
            this.btnTorles.TabIndex = 2;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // btnFajlbol
            // 
            this.btnFajlbol.Location = new System.Drawing.Point(659, 246);
            this.btnFajlbol.Name = "btnFajlbol";
            this.btnFajlbol.Size = new System.Drawing.Size(75, 23);
            this.btnFajlbol.TabIndex = 3;
            this.btnFajlbol.Text = "Beolvasás";
            this.btnFajlbol.UseVisualStyleBackColor = true;
            this.btnFajlbol.Click += new System.EventHandler(this.btnFajlbol_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(659, 298);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 23);
            this.btnMentes.TabIndex = 4;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnModosit
            // 
            this.btnModosit.Location = new System.Drawing.Point(659, 95);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(75, 23);
            this.btnModosit.TabIndex = 5;
            this.btnModosit.Text = "Módosítás";
            this.btnModosit.UseVisualStyleBackColor = true;
            this.btnModosit.Click += new System.EventHandler(this.btnModosit_Click);
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnFajlbol);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnFelvitel);
            this.Controls.Add(this.ltvAdatok);
            this.Name = "frmFo";
            this.Text = "Modális formok";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFo_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ltvAdatok;
        private System.Windows.Forms.Button btnFelvitel;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnFajlbol;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnModosit;
        private System.Windows.Forms.ColumnHeader chNev;
        private System.Windows.Forms.ColumnHeader chAzonosito;
        private System.Windows.Forms.ColumnHeader chSzulDatum;
    }
}

