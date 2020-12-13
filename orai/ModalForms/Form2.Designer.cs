namespace ModalForms
{
    partial class FormAdat
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
            this.tbxNev = new System.Windows.Forms.TextBox();
            this.tbxAzon = new System.Windows.Forms.TextBox();
            this.dtpSzuletes = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnMegse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxNev
            // 
            this.tbxNev.Location = new System.Drawing.Point(163, 35);
            this.tbxNev.Name = "tbxNev";
            this.tbxNev.Size = new System.Drawing.Size(198, 20);
            this.tbxNev.TabIndex = 0;
            // 
            // tbxAzon
            // 
            this.tbxAzon.Location = new System.Drawing.Point(163, 97);
            this.tbxAzon.Name = "tbxAzon";
            this.tbxAzon.Size = new System.Drawing.Size(197, 20);
            this.tbxAzon.TabIndex = 1;
            // 
            // dtpSzuletes
            // 
            this.dtpSzuletes.Location = new System.Drawing.Point(163, 159);
            this.dtpSzuletes.Name = "dtpSzuletes";
            this.dtpSzuletes.Size = new System.Drawing.Size(200, 20);
            this.dtpSzuletes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Név: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Azonosító: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Születési dátum: ";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(238, 260);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnMegse
            // 
            this.btnMegse.Location = new System.Drawing.Point(108, 260);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(75, 23);
            this.btnMegse.TabIndex = 7;
            this.btnMegse.Text = "Mégse...";
            this.btnMegse.UseVisualStyleBackColor = true;
            this.btnMegse.Click += new System.EventHandler(this.btnMegse_Click);
            // 
            // FormAdat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 334);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSzuletes);
            this.Controls.Add(this.tbxAzon);
            this.Controls.Add(this.tbxNev);
            this.Name = "FormAdat";
            this.Text = "Adatbevitel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNev;
        private System.Windows.Forms.TextBox tbxAzon;
        private System.Windows.Forms.DateTimePicker dtpSzuletes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnMegse;
    }
}