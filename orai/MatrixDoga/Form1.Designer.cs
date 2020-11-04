namespace MatrixDoga
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
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvA = new System.Windows.Forms.DataGridView();
            this.dgvB = new System.Windows.Forms.DataGridView();
            this.lblSkalar = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.lblAtloFel = new System.Windows.Forms.Label();
            this.lblAtlo = new System.Windows.Forms.Label();
            this.lblSkalarFord = new System.Windows.Forms.Label();
            this.rtbxTeszt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            this.SuspendLayout();
            // 
            // nudN
            // 
            this.nudN.Location = new System.Drawing.Point(36, 38);
            this.nudN.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudN.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(120, 20);
            this.nudN.TabIndex = 0;
            this.nudN.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adja meg a mátrixok méretét: ";
            // 
            // dgvA
            // 
            this.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA.Location = new System.Drawing.Point(36, 93);
            this.dgvA.Name = "dgvA";
            this.dgvA.Size = new System.Drawing.Size(339, 287);
            this.dgvA.TabIndex = 2;
            // 
            // dgvB
            // 
            this.dgvB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvB.Location = new System.Drawing.Point(381, 93);
            this.dgvB.Name = "dgvB";
            this.dgvB.Size = new System.Drawing.Size(339, 287);
            this.dgvB.TabIndex = 3;
            // 
            // lblSkalar
            // 
            this.lblSkalar.Location = new System.Drawing.Point(753, 93);
            this.lblSkalar.Name = "lblSkalar";
            this.lblSkalar.Size = new System.Drawing.Size(262, 23);
            this.lblSkalar.TabIndex = 4;
            this.lblSkalar.Text = "Skalár";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(186, 38);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 5;
            this.btnGen.Text = "Generálj!";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // lblAtloFel
            // 
            this.lblAtloFel.Location = new System.Drawing.Point(753, 258);
            this.lblAtloFel.Name = "lblAtloFel";
            this.lblAtloFel.Size = new System.Drawing.Size(262, 23);
            this.lblAtloFel.TabIndex = 6;
            this.lblAtloFel.Text = "Átló felett";
            // 
            // lblAtlo
            // 
            this.lblAtlo.Location = new System.Drawing.Point(753, 199);
            this.lblAtlo.Name = "lblAtlo";
            this.lblAtlo.Size = new System.Drawing.Size(262, 23);
            this.lblAtlo.TabIndex = 7;
            this.lblAtlo.Text = "Átlóösszeg";
            // 
            // lblSkalarFord
            // 
            this.lblSkalarFord.Location = new System.Drawing.Point(753, 147);
            this.lblSkalarFord.Name = "lblSkalarFord";
            this.lblSkalarFord.Size = new System.Drawing.Size(262, 23);
            this.lblSkalarFord.TabIndex = 8;
            this.lblSkalarFord.Text = "Skalár fordított";
            // 
            // rtbxTeszt
            // 
            this.rtbxTeszt.Location = new System.Drawing.Point(756, 294);
            this.rtbxTeszt.Name = "rtbxTeszt";
            this.rtbxTeszt.Size = new System.Drawing.Size(241, 105);
            this.rtbxTeszt.TabIndex = 9;
            this.rtbxTeszt.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.rtbxTeszt);
            this.Controls.Add(this.lblSkalarFord);
            this.Controls.Add(this.lblAtlo);
            this.Controls.Add(this.lblAtloFel);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.lblSkalar);
            this.Controls.Add(this.dgvB);
            this.Controls.Add(this.dgvA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudN);
            this.Name = "Form1";
            this.Text = "Mátrix dolgozat";
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvA;
        private System.Windows.Forms.DataGridView dgvB;
        private System.Windows.Forms.Label lblSkalar;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Label lblAtloFel;
        private System.Windows.Forms.Label lblAtlo;
        private System.Windows.Forms.Label lblSkalarFord;
        private System.Windows.Forms.RichTextBox rtbxTeszt;
    }
}

