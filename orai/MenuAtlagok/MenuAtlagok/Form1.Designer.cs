namespace MenuAtlagok
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.nud3 = new System.Windows.Forms.NumericUpDown();
            this.lbxEredm = new System.Windows.Forms.ListBox();
            this.mniSzamtani = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMertani = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHarmonik = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLegnagyobb = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTorol = new System.Windows.Forms.ToolStripMenuItem();
            this.mniKilep = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mértaniÁtlagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harmonikusÁtlagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legnagyobbSzámToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törölToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSzamtani,
            this.mniMertani,
            this.mniHarmonik,
            this.mniLegnagyobb,
            this.mniTorol,
            this.mniKilep});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adjon meg három számot!";
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(26, 85);
            this.nud1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(120, 20);
            this.nud1.TabIndex = 2;
            this.nud1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud2
            // 
            this.nud2.Location = new System.Drawing.Point(196, 85);
            this.nud2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(120, 20);
            this.nud2.TabIndex = 3;
            this.nud2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud3
            // 
            this.nud3.Location = new System.Drawing.Point(366, 85);
            this.nud3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud3.Name = "nud3";
            this.nud3.Size = new System.Drawing.Size(120, 20);
            this.nud3.TabIndex = 4;
            this.nud3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbxEredm
            // 
            this.lbxEredm.ContextMenuStrip = this.contextMenuStrip1;
            this.lbxEredm.FormattingEnabled = true;
            this.lbxEredm.Location = new System.Drawing.Point(26, 142);
            this.lbxEredm.Name = "lbxEredm";
            this.lbxEredm.Size = new System.Drawing.Size(460, 238);
            this.lbxEredm.TabIndex = 5;
            // 
            // mniSzamtani
            // 
            this.mniSzamtani.Image = ((System.Drawing.Image)(resources.GetObject("mniSzamtani.Image")));
            this.mniSzamtani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mniSzamtani.Name = "mniSzamtani";
            this.mniSzamtani.Size = new System.Drawing.Size(112, 20);
            this.mniSzamtani.Text = "Számtani átlag";
            this.mniSzamtani.Click += new System.EventHandler(this.mniSzamtani_Click);
            // 
            // mniMertani
            // 
            this.mniMertani.Name = "mniMertani";
            this.mniMertani.Size = new System.Drawing.Size(89, 20);
            this.mniMertani.Text = "Mértani átlag";
            this.mniMertani.Click += new System.EventHandler(this.mniMertani_Click);
            // 
            // mniHarmonik
            // 
            this.mniHarmonik.Name = "mniHarmonik";
            this.mniHarmonik.Size = new System.Drawing.Size(113, 20);
            this.mniHarmonik.Text = "Harmonikus átlag";
            this.mniHarmonik.Click += new System.EventHandler(this.mniHarmonik_Click);
            // 
            // mniLegnagyobb
            // 
            this.mniLegnagyobb.Name = "mniLegnagyobb";
            this.mniLegnagyobb.Size = new System.Drawing.Size(115, 20);
            this.mniLegnagyobb.Text = "Legnagyobb szám";
            this.mniLegnagyobb.Click += new System.EventHandler(this.mniLegnagyobb_Click);
            // 
            // mniTorol
            // 
            this.mniTorol.Name = "mniTorol";
            this.mniTorol.Size = new System.Drawing.Size(46, 20);
            this.mniTorol.Text = "Töröl";
            this.mniTorol.Click += new System.EventHandler(this.mniTorol_Click);
            // 
            // mniKilep
            // 
            this.mniKilep.Name = "mniKilep";
            this.mniKilep.Size = new System.Drawing.Size(45, 20);
            this.mniKilep.Text = "Kilép";
            this.mniKilep.Click += new System.EventHandler(this.mniKilep_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mértaniÁtlagToolStripMenuItem,
            this.harmonikusÁtlagToolStripMenuItem,
            this.legnagyobbSzámToolStripMenuItem,
            this.törölToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem1.Text = "Számtani átlag";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.mniSzamtani_Click);
            // 
            // mértaniÁtlagToolStripMenuItem
            // 
            this.mértaniÁtlagToolStripMenuItem.Name = "mértaniÁtlagToolStripMenuItem";
            this.mértaniÁtlagToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.mértaniÁtlagToolStripMenuItem.Text = "Mértani átlag";
            this.mértaniÁtlagToolStripMenuItem.Click += new System.EventHandler(this.mniMertani_Click);
            // 
            // harmonikusÁtlagToolStripMenuItem
            // 
            this.harmonikusÁtlagToolStripMenuItem.Name = "harmonikusÁtlagToolStripMenuItem";
            this.harmonikusÁtlagToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.harmonikusÁtlagToolStripMenuItem.Text = "Harmonikus átlag";
            this.harmonikusÁtlagToolStripMenuItem.Click += new System.EventHandler(this.mniHarmonik_Click);
            // 
            // legnagyobbSzámToolStripMenuItem
            // 
            this.legnagyobbSzámToolStripMenuItem.Name = "legnagyobbSzámToolStripMenuItem";
            this.legnagyobbSzámToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.legnagyobbSzámToolStripMenuItem.Text = "Legnagyobb szám";
            this.legnagyobbSzámToolStripMenuItem.Click += new System.EventHandler(this.mniLegnagyobb_Click);
            // 
            // törölToolStripMenuItem
            // 
            this.törölToolStripMenuItem.Name = "törölToolStripMenuItem";
            this.törölToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.törölToolStripMenuItem.Text = "Töröl";
            this.törölToolStripMenuItem.Click += new System.EventHandler(this.mniTorol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxEredm);
            this.Controls.Add(this.nud3);
            this.Controls.Add(this.nud2);
            this.Controls.Add(this.nud1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Átlagok menüvel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniSzamtani;
        private System.Windows.Forms.ToolStripMenuItem mniMertani;
        private System.Windows.Forms.ToolStripMenuItem mniHarmonik;
        private System.Windows.Forms.ToolStripMenuItem mniLegnagyobb;
        private System.Windows.Forms.ToolStripMenuItem mniTorol;
        private System.Windows.Forms.ToolStripMenuItem mniKilep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.NumericUpDown nud2;
        private System.Windows.Forms.NumericUpDown nud3;
        private System.Windows.Forms.ListBox lbxEredm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mértaniÁtlagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harmonikusÁtlagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legnagyobbSzámToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törölToolStripMenuItem;
    }
}

