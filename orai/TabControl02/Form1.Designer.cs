namespace TabControl02
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
            this.tbpAdatok = new System.Windows.Forms.TabPage();
            this.btnAdatOk = new System.Windows.Forms.Button();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.tbxA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpEredm = new System.Windows.Forms.TabPage();
            this.btnKilep = new System.Windows.Forms.Button();
            this.lblEredm = new System.Windows.Forms.Label();
            this.tbcElso.SuspendLayout();
            this.tbpAdatok.SuspendLayout();
            this.tbpEredm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcElso
            // 
            this.tbcElso.Controls.Add(this.tbpAdatok);
            this.tbcElso.Controls.Add(this.tbpEredm);
            this.tbcElso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcElso.Location = new System.Drawing.Point(0, 0);
            this.tbcElso.Name = "tbcElso";
            this.tbcElso.SelectedIndex = 0;
            this.tbcElso.Size = new System.Drawing.Size(800, 450);
            this.tbcElso.TabIndex = 0;
            // 
            // tbpAdatok
            // 
            this.tbpAdatok.Controls.Add(this.btnAdatOk);
            this.tbpAdatok.Controls.Add(this.tbxB);
            this.tbpAdatok.Controls.Add(this.tbxA);
            this.tbpAdatok.Controls.Add(this.label1);
            this.tbpAdatok.Location = new System.Drawing.Point(4, 22);
            this.tbpAdatok.Name = "tbpAdatok";
            this.tbpAdatok.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAdatok.Size = new System.Drawing.Size(792, 424);
            this.tbpAdatok.TabIndex = 0;
            this.tbpAdatok.Text = "Adatok";
            this.tbpAdatok.UseVisualStyleBackColor = true;
            this.tbpAdatok.Enter += new System.EventHandler(this.tbpAdatok_Enter);
            // 
            // btnAdatOk
            // 
            this.btnAdatOk.Location = new System.Drawing.Point(33, 166);
            this.btnAdatOk.Name = "btnAdatOk";
            this.btnAdatOk.Size = new System.Drawing.Size(75, 23);
            this.btnAdatOk.TabIndex = 2;
            this.btnAdatOk.Text = "OK";
            this.btnAdatOk.UseVisualStyleBackColor = true;
            // 
            // tbxB
            // 
            this.tbxB.Location = new System.Drawing.Point(20, 101);
            this.tbxB.Name = "tbxB";
            this.tbxB.Size = new System.Drawing.Size(100, 20);
            this.tbxB.TabIndex = 1;
            this.tbxB.Leave += new System.EventHandler(this.Ellenoriz);
            // 
            // tbxA
            // 
            this.tbxA.Location = new System.Drawing.Point(20, 51);
            this.tbxA.Name = "tbxA";
            this.tbxA.Size = new System.Drawing.Size(100, 20);
            this.tbxA.TabIndex = 0;
            this.tbxA.Leave += new System.EventHandler(this.Ellenoriz);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kérem adjon meg két egész számot:";
            // 
            // tbpEredm
            // 
            this.tbpEredm.Controls.Add(this.btnKilep);
            this.tbpEredm.Controls.Add(this.lblEredm);
            this.tbpEredm.Location = new System.Drawing.Point(4, 22);
            this.tbpEredm.Name = "tbpEredm";
            this.tbpEredm.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEredm.Size = new System.Drawing.Size(792, 424);
            this.tbpEredm.TabIndex = 1;
            this.tbpEredm.Text = "Eredmények";
            this.tbpEredm.UseVisualStyleBackColor = true;
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(29, 149);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 23);
            this.btnKilep.TabIndex = 0;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            // 
            // lblEredm
            // 
            this.lblEredm.AutoSize = true;
            this.lblEredm.Location = new System.Drawing.Point(26, 26);
            this.lblEredm.Name = "lblEredm";
            this.lblEredm.Size = new System.Drawing.Size(66, 13);
            this.lblEredm.TabIndex = 9;
            this.lblEredm.Text = "Eredmények";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcElso);
            this.Name = "Form1";
            this.Text = "TabControl példa 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tbcElso.ResumeLayout(false);
            this.tbpAdatok.ResumeLayout(false);
            this.tbpAdatok.PerformLayout();
            this.tbpEredm.ResumeLayout(false);
            this.tbpEredm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcElso;
        private System.Windows.Forms.TabPage tbpAdatok;
        private System.Windows.Forms.TabPage tbpEredm;
        private System.Windows.Forms.Button btnAdatOk;
        private System.Windows.Forms.TextBox tbxB;
        private System.Windows.Forms.TextBox tbxA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.Label lblEredm;
    }
}

