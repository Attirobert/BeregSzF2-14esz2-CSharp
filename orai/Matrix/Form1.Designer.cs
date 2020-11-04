namespace Matrix
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
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbEredm = new System.Windows.Forms.RichTextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.nudSor = new System.Windows.Forms.NumericUpDown();
            this.nudOszlop = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOszlop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatrix
            // 
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.Location = new System.Drawing.Point(35, 87);
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.Size = new System.Drawing.Size(453, 312);
            this.dgvMatrix.TabIndex = 0;
            this.dgvMatrix.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatrix_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adja meg a mátrix méretét: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "sor: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "oszlop: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Eredmények:";
            // 
            // rtbEredm
            // 
            this.rtbEredm.Location = new System.Drawing.Point(532, 104);
            this.rtbEredm.Name = "rtbEredm";
            this.rtbEredm.Size = new System.Drawing.Size(223, 295);
            this.rtbEredm.TabIndex = 5;
            this.rtbEredm.Text = "";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(412, 27);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 6;
            this.btnGen.Text = "Generálj!";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // nudSor
            // 
            this.nudSor.Location = new System.Drawing.Point(208, 28);
            this.nudSor.Name = "nudSor";
            this.nudSor.Size = new System.Drawing.Size(44, 20);
            this.nudSor.TabIndex = 7;
            // 
            // nudOszlop
            // 
            this.nudOszlop.Location = new System.Drawing.Point(320, 28);
            this.nudOszlop.Name = "nudOszlop";
            this.nudOszlop.Size = new System.Drawing.Size(52, 20);
            this.nudOszlop.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudOszlop);
            this.Controls.Add(this.nudSor);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.rtbEredm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMatrix);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOszlop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbEredm;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.NumericUpDown nudSor;
        private System.Windows.Forms.NumericUpDown nudOszlop;
    }
}

