namespace MatrixTranszform
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTranszform = new System.Windows.Forms.ToolStripMenuItem();
            this.mniParatlan = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFoatlo = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSorok = new System.Windows.Forms.ToolStripMenuItem();
            this.mniOszlopok = new System.Windows.Forms.ToolStripMenuItem();
            this.mniKilep = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvM = new System.Windows.Forms.DataGridView();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblFoatlo = new System.Windows.Forms.Label();
            this.lblSorok = new System.Windows.Forms.Label();
            this.lblOszlopok = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniGeneral,
            this.mniTranszform,
            this.mniParatlan,
            this.mniFoatlo,
            this.mniSorok,
            this.mniOszlopok,
            this.mniKilep});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniGeneral
            // 
            this.mniGeneral.Name = "mniGeneral";
            this.mniGeneral.Size = new System.Drawing.Size(70, 20);
            this.mniGeneral.Text = "Generálás";
            this.mniGeneral.Click += new System.EventHandler(this.mniGeneral_Click);
            // 
            // mniTranszform
            // 
            this.mniTranszform.Name = "mniTranszform";
            this.mniTranszform.Size = new System.Drawing.Size(98, 20);
            this.mniTranszform.Text = "Transzformálás";
            this.mniTranszform.Click += new System.EventHandler(this.mniTranszform_Click);
            // 
            // mniParatlan
            // 
            this.mniParatlan.Name = "mniParatlan";
            this.mniParatlan.Size = new System.Drawing.Size(149, 20);
            this.mniParatlan.Text = "Páratlan számok összege";
            this.mniParatlan.Click += new System.EventHandler(this.mniParatlan_Click);
            // 
            // mniFoatlo
            // 
            this.mniFoatlo.Name = "mniFoatlo";
            this.mniFoatlo.Size = new System.Drawing.Size(96, 20);
            this.mniFoatlo.Text = "Főátló összege";
            this.mniFoatlo.Click += new System.EventHandler(this.mniFoatlo_Click);
            // 
            // mniSorok
            // 
            this.mniSorok.Name = "mniSorok";
            this.mniSorok.Size = new System.Drawing.Size(93, 20);
            this.mniSorok.Text = "Sorok összege";
            this.mniSorok.Click += new System.EventHandler(this.mniSorok_Click);
            // 
            // mniOszlopok
            // 
            this.mniOszlopok.Name = "mniOszlopok";
            this.mniOszlopok.Size = new System.Drawing.Size(112, 20);
            this.mniOszlopok.Text = "Oszlopok összege";
            this.mniOszlopok.Click += new System.EventHandler(this.mniOszlopok_Click);
            // 
            // mniKilep
            // 
            this.mniKilep.Name = "mniKilep";
            this.mniKilep.Size = new System.Drawing.Size(56, 20);
            this.mniKilep.Text = "Kilépés";
            // 
            // dgvM
            // 
            this.dgvM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvM.Location = new System.Drawing.Point(13, 28);
            this.dgvM.Name = "dgvM";
            this.dgvM.Size = new System.Drawing.Size(409, 306);
            this.dgvM.TabIndex = 1;
            this.dgvM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvM_CellContentClick);
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(473, 56);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(131, 13);
            this.lblPlan.TabIndex = 2;
            this.lblPlan.Text = "Páratlan elemek összege :";
            // 
            // lblFoatlo
            // 
            this.lblFoatlo.AutoSize = true;
            this.lblFoatlo.Location = new System.Drawing.Point(473, 106);
            this.lblFoatlo.Name = "lblFoatlo";
            this.lblFoatlo.Size = new System.Drawing.Size(35, 13);
            this.lblFoatlo.TabIndex = 3;
            this.lblFoatlo.Text = "label2";
            // 
            // lblSorok
            // 
            this.lblSorok.AutoSize = true;
            this.lblSorok.Location = new System.Drawing.Point(473, 156);
            this.lblSorok.Name = "lblSorok";
            this.lblSorok.Size = new System.Drawing.Size(35, 13);
            this.lblSorok.TabIndex = 4;
            this.lblSorok.Text = "label3";
            // 
            // lblOszlopok
            // 
            this.lblOszlopok.AutoSize = true;
            this.lblOszlopok.Location = new System.Drawing.Point(473, 206);
            this.lblOszlopok.Name = "lblOszlopok";
            this.lblOszlopok.Size = new System.Drawing.Size(35, 13);
            this.lblOszlopok.TabIndex = 5;
            this.lblOszlopok.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOszlopok);
            this.Controls.Add(this.lblSorok);
            this.Controls.Add(this.lblFoatlo);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.dgvM);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Mátrix transzformáció";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniGeneral;
        private System.Windows.Forms.ToolStripMenuItem mniTranszform;
        private System.Windows.Forms.ToolStripMenuItem mniParatlan;
        private System.Windows.Forms.ToolStripMenuItem mniFoatlo;
        private System.Windows.Forms.ToolStripMenuItem mniSorok;
        private System.Windows.Forms.ToolStripMenuItem mniOszlopok;
        private System.Windows.Forms.ToolStripMenuItem mniKilep;
        private System.Windows.Forms.DataGridView dgvM;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblFoatlo;
        private System.Windows.Forms.Label lblSorok;
        private System.Windows.Forms.Label lblOszlopok;
    }
}

