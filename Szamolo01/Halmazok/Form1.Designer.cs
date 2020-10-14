namespace Halmazok
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
            this.lbxA = new System.Windows.Forms.ListBox();
            this.lbxB = new System.Windows.Forms.ListBox();
            this.lbxAuB = new System.Windows.Forms.ListBox();
            this.lbxAmB = new System.Windows.Forms.ListBox();
            this.lbxAkB = new System.Windows.Forms.ListBox();
            this.lbxBkA = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nlA = new System.Windows.Forms.NumericUpDown();
            this.nlB = new System.Windows.Forms.NumericUpDown();
            this.btnGen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nlA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlB)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxA
            // 
            this.lbxA.FormattingEnabled = true;
            this.lbxA.Location = new System.Drawing.Point(13, 43);
            this.lbxA.Name = "lbxA";
            this.lbxA.Size = new System.Drawing.Size(120, 238);
            this.lbxA.TabIndex = 0;
            // 
            // lbxB
            // 
            this.lbxB.FormattingEnabled = true;
            this.lbxB.Location = new System.Drawing.Point(139, 43);
            this.lbxB.Name = "lbxB";
            this.lbxB.Size = new System.Drawing.Size(120, 238);
            this.lbxB.TabIndex = 1;
            // 
            // lbxAuB
            // 
            this.lbxAuB.FormattingEnabled = true;
            this.lbxAuB.Location = new System.Drawing.Point(265, 43);
            this.lbxAuB.Name = "lbxAuB";
            this.lbxAuB.Size = new System.Drawing.Size(120, 238);
            this.lbxAuB.TabIndex = 2;
            // 
            // lbxAmB
            // 
            this.lbxAmB.FormattingEnabled = true;
            this.lbxAmB.Location = new System.Drawing.Point(391, 43);
            this.lbxAmB.Name = "lbxAmB";
            this.lbxAmB.Size = new System.Drawing.Size(120, 238);
            this.lbxAmB.TabIndex = 3;
            // 
            // lbxAkB
            // 
            this.lbxAkB.FormattingEnabled = true;
            this.lbxAkB.Location = new System.Drawing.Point(517, 43);
            this.lbxAkB.Name = "lbxAkB";
            this.lbxAkB.Size = new System.Drawing.Size(120, 238);
            this.lbxAkB.TabIndex = 4;
            // 
            // lbxBkA
            // 
            this.lbxBkA.FormattingEnabled = true;
            this.lbxBkA.Location = new System.Drawing.Point(643, 43);
            this.lbxBkA.Name = "lbxBkA";
            this.lbxBkA.Size = new System.Drawing.Size(120, 238);
            this.lbxBkA.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "\"A\" halmaz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "\"B\" halmaz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "A unio B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "A metszet B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "A - B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(643, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "B - A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "A halmazok elemszáma:";
            // 
            // nlA
            // 
            this.nlA.Location = new System.Drawing.Point(16, 348);
            this.nlA.Name = "nlA";
            this.nlA.Size = new System.Drawing.Size(67, 20);
            this.nlA.TabIndex = 13;
            // 
            // nlB
            // 
            this.nlB.Location = new System.Drawing.Point(89, 348);
            this.nlB.Name = "nlB";
            this.nlB.Size = new System.Drawing.Size(67, 20);
            this.nlB.TabIndex = 14;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(162, 345);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 15;
            this.btnGen.Text = "Generálj!";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.nlB);
            this.Controls.Add(this.nlA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxBkA);
            this.Controls.Add(this.lbxAkB);
            this.Controls.Add(this.lbxAmB);
            this.Controls.Add(this.lbxAuB);
            this.Controls.Add(this.lbxB);
            this.Controls.Add(this.lbxA);
            this.Name = "Form1";
            this.Text = "Halmaz műveletek";
            ((System.ComponentModel.ISupportInitialize)(this.nlA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxA;
        private System.Windows.Forms.ListBox lbxB;
        private System.Windows.Forms.ListBox lbxAuB;
        private System.Windows.Forms.ListBox lbxAmB;
        private System.Windows.Forms.ListBox lbxAkB;
        private System.Windows.Forms.ListBox lbxBkA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nlA;
        private System.Windows.Forms.NumericUpDown nlB;
        private System.Windows.Forms.Button btnGen;
    }
}

