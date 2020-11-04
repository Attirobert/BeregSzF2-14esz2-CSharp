namespace Szorzotabla
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
            this.dgvSzorzo = new System.Windows.Forms.DataGridView();
            this.lblJo = new System.Windows.Forms.Label();
            this.lblRossz = new System.Windows.Forms.Label();
            this.btnKilep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzorzo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSzorzo
            // 
            this.dgvSzorzo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSzorzo.Location = new System.Drawing.Point(26, 13);
            this.dgvSzorzo.Name = "dgvSzorzo";
            this.dgvSzorzo.Size = new System.Drawing.Size(354, 308);
            this.dgvSzorzo.TabIndex = 0;
            this.dgvSzorzo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSzorzo_CellValueChanged);
            // 
            // lblJo
            // 
            this.lblJo.AutoSize = true;
            this.lblJo.Location = new System.Drawing.Point(29, 339);
            this.lblJo.Name = "lblJo";
            this.lblJo.Size = new System.Drawing.Size(109, 13);
            this.lblJo.TabIndex = 1;
            this.lblJo.Text = "A jó válaszok száma: ";
            // 
            // lblRossz
            // 
            this.lblRossz.AutoSize = true;
            this.lblRossz.Location = new System.Drawing.Point(29, 356);
            this.lblRossz.Name = "lblRossz";
            this.lblRossz.Size = new System.Drawing.Size(120, 13);
            this.lblRossz.TabIndex = 2;
            this.lblRossz.Text = "Rossz válaszok száma: ";
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(29, 388);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 23);
            this.btnKilep.TabIndex = 3;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.lblRossz);
            this.Controls.Add(this.lblJo);
            this.Controls.Add(this.dgvSzorzo);
            this.Name = "Form1";
            this.Text = "Szorzótábla";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzorzo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSzorzo;
        private System.Windows.Forms.Label lblJo;
        private System.Windows.Forms.Label lblRossz;
        private System.Windows.Forms.Button btnKilep;
    }
}

