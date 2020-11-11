namespace Dolgozat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BekertSzam = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Matrix1 = new System.Windows.Forms.DataGridView();
            this.Matrix2 = new System.Windows.Forms.DataGridView();
            this.Buttom = new System.Windows.Forms.Button();
            this.Eredmeny = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BekertSzam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix2)).BeginInit();
            this.SuspendLayout();
            // 
            // BekertSzam
            // 
            this.BekertSzam.Location = new System.Drawing.Point(34, 57);
            this.BekertSzam.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.BekertSzam.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BekertSzam.Name = "BekertSzam";
            this.BekertSzam.Size = new System.Drawing.Size(66, 20);
            this.BekertSzam.TabIndex = 1;
            this.BekertSzam.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adj meg egy természetes számot 5-15 között";
            // 
            // Matrix1
            // 
            this.Matrix1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matrix1.Location = new System.Drawing.Point(34, 117);
            this.Matrix1.Name = "Matrix1";
            this.Matrix1.Size = new System.Drawing.Size(327, 300);
            this.Matrix1.TabIndex = 3;
            // 
            // Matrix2
            // 
            this.Matrix2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matrix2.Location = new System.Drawing.Point(395, 117);
            this.Matrix2.Name = "Matrix2";
            this.Matrix2.Size = new System.Drawing.Size(327, 300);
            this.Matrix2.TabIndex = 4;
            // 
            // Buttom
            // 
            this.Buttom.Location = new System.Drawing.Point(116, 54);
            this.Buttom.Name = "Buttom";
            this.Buttom.Size = new System.Drawing.Size(75, 23);
            this.Buttom.TabIndex = 5;
            this.Buttom.Text = "Generate";
            this.Buttom.UseVisualStyleBackColor = true;
            this.Buttom.Click += new System.EventHandler(this.Buttom_Click);
            // 
            // Eredmeny
            // 
            this.Eredmeny.AutoSize = true;
            this.Eredmeny.Location = new System.Drawing.Point(472, 28);
            this.Eredmeny.Name = "Eredmeny";
            this.Eredmeny.Size = new System.Drawing.Size(0, 13);
            this.Eredmeny.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Eredmény:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Eredmeny);
            this.Controls.Add(this.Buttom);
            this.Controls.Add(this.Matrix2);
            this.Controls.Add(this.Matrix1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BekertSzam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dolgozat";
            ((System.ComponentModel.ISupportInitialize)(this.BekertSzam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown BekertSzam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Matrix1;
        private System.Windows.Forms.DataGridView Matrix2;
        private System.Windows.Forms.Button Buttom;
        private System.Windows.Forms.Label Eredmeny;
        private System.Windows.Forms.Label label3;
    }
}

