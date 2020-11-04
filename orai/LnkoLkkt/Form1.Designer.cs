namespace LnkoLkkt
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
            this.tbxA = new System.Windows.Forms.TextBox();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbLnko = new System.Windows.Forms.RadioButton();
            this.rbLkkt = new System.Windows.Forms.RadioButton();
            this.btnSzamolj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxA
            // 
            this.tbxA.Location = new System.Drawing.Point(56, 39);
            this.tbxA.Name = "tbxA";
            this.tbxA.Size = new System.Drawing.Size(100, 20);
            this.tbxA.TabIndex = 0;
            // 
            // tbxB
            // 
            this.tbxB.Location = new System.Drawing.Point(56, 85);
            this.tbxB.Name = "tbxB";
            this.tbxB.Size = new System.Drawing.Size(100, 20);
            this.tbxB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Válasszon!";
            // 
            // rbLnko
            // 
            this.rbLnko.AutoSize = true;
            this.rbLnko.Location = new System.Drawing.Point(216, 49);
            this.rbLnko.Name = "rbLnko";
            this.rbLnko.Size = new System.Drawing.Size(54, 17);
            this.rbLnko.TabIndex = 3;
            this.rbLnko.TabStop = true;
            this.rbLnko.Text = "LNKO";
            this.rbLnko.UseVisualStyleBackColor = true;
            // 
            // rbLkkt
            // 
            this.rbLkkt.AutoSize = true;
            this.rbLkkt.Location = new System.Drawing.Point(216, 85);
            this.rbLkkt.Name = "rbLkkt";
            this.rbLkkt.Size = new System.Drawing.Size(52, 17);
            this.rbLkkt.TabIndex = 4;
            this.rbLkkt.TabStop = true;
            this.rbLkkt.Text = "LKKT";
            this.rbLkkt.UseVisualStyleBackColor = true;
            // 
            // btnSzamolj
            // 
            this.btnSzamolj.Location = new System.Drawing.Point(360, 13);
            this.btnSzamolj.Name = "btnSzamolj";
            this.btnSzamolj.Size = new System.Drawing.Size(75, 23);
            this.btnSzamolj.TabIndex = 5;
            this.btnSzamolj.Text = "Számolj!";
            this.btnSzamolj.UseVisualStyleBackColor = true;
            this.btnSzamolj.Click += new System.EventHandler(this.btnSzamolj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSzamolj);
            this.Controls.Add(this.rbLkkt);
            this.Controls.Add(this.rbLnko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxB);
            this.Controls.Add(this.tbxA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxA;
        private System.Windows.Forms.TextBox tbxB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbLnko;
        private System.Windows.Forms.RadioButton rbLkkt;
        private System.Windows.Forms.Button btnSzamolj;
    }
}

