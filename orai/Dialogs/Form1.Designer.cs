namespace Dialogs
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
            this.lblSzin = new System.Windows.Forms.Label();
            this.lblSzinkod = new System.Windows.Forms.Label();
            this.gbxSzinezes = new System.Windows.Forms.GroupBox();
            this.btnSzinek = new System.Windows.Forms.Button();
            this.pbKep = new System.Windows.Forms.PictureBox();
            this.btnKep = new System.Windows.Forms.Button();
            this.tbxSzoveg = new System.Windows.Forms.TextBox();
            this.btnNyit = new System.Windows.Forms.Button();
            this.btnMent = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.gbxSzinezes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSzin
            // 
            this.lblSzin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSzin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSzin.Location = new System.Drawing.Point(6, 16);
            this.lblSzin.Name = "lblSzin";
            this.lblSzin.Size = new System.Drawing.Size(211, 35);
            this.lblSzin.TabIndex = 0;
            this.lblSzin.Text = "Minta szöveg";
            this.lblSzin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSzinkod
            // 
            this.lblSzinkod.AutoSize = true;
            this.lblSzinkod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSzinkod.Location = new System.Drawing.Point(7, 60);
            this.lblSzinkod.Name = "lblSzinkod";
            this.lblSzinkod.Size = new System.Drawing.Size(53, 13);
            this.lblSzinkod.TabIndex = 1;
            this.lblSzinkod.Text = "Színkód: ";
            // 
            // gbxSzinezes
            // 
            this.gbxSzinezes.Controls.Add(this.btnSzinek);
            this.gbxSzinezes.Controls.Add(this.lblSzinkod);
            this.gbxSzinezes.Controls.Add(this.lblSzin);
            this.gbxSzinezes.Location = new System.Drawing.Point(12, 27);
            this.gbxSzinezes.Name = "gbxSzinezes";
            this.gbxSzinezes.Size = new System.Drawing.Size(223, 160);
            this.gbxSzinezes.TabIndex = 2;
            this.gbxSzinezes.TabStop = false;
            this.gbxSzinezes.Text = "Szinzés";
            // 
            // btnSzinek
            // 
            this.btnSzinek.Location = new System.Drawing.Point(31, 113);
            this.btnSzinek.Name = "btnSzinek";
            this.btnSzinek.Size = new System.Drawing.Size(75, 23);
            this.btnSzinek.TabIndex = 2;
            this.btnSzinek.Text = "Szinek";
            this.btnSzinek.UseVisualStyleBackColor = true;
            this.btnSzinek.Click += new System.EventHandler(this.btnSzinek_Click);
            // 
            // pbKep
            // 
            this.pbKep.Location = new System.Drawing.Point(265, 27);
            this.pbKep.Name = "pbKep";
            this.pbKep.Size = new System.Drawing.Size(508, 306);
            this.pbKep.TabIndex = 3;
            this.pbKep.TabStop = false;
            // 
            // btnKep
            // 
            this.btnKep.Location = new System.Drawing.Point(499, 364);
            this.btnKep.Name = "btnKep";
            this.btnKep.Size = new System.Drawing.Size(75, 23);
            this.btnKep.TabIndex = 4;
            this.btnKep.Text = "Képek";
            this.btnKep.UseVisualStyleBackColor = true;
            this.btnKep.Click += new System.EventHandler(this.btnKep_Click);
            // 
            // tbxSzoveg
            // 
            this.tbxSzoveg.Location = new System.Drawing.Point(22, 445);
            this.tbxSzoveg.Multiline = true;
            this.tbxSzoveg.Name = "tbxSzoveg";
            this.tbxSzoveg.Size = new System.Drawing.Size(751, 244);
            this.tbxSzoveg.TabIndex = 5;
            // 
            // btnNyit
            // 
            this.btnNyit.Location = new System.Drawing.Point(197, 733);
            this.btnNyit.Name = "btnNyit";
            this.btnNyit.Size = new System.Drawing.Size(75, 23);
            this.btnNyit.TabIndex = 6;
            this.btnNyit.Text = "Megnyit";
            this.btnNyit.UseVisualStyleBackColor = true;
            this.btnNyit.Click += new System.EventHandler(this.btnNyit_Click);
            // 
            // btnMent
            // 
            this.btnMent.Location = new System.Drawing.Point(377, 733);
            this.btnMent.Name = "btnMent";
            this.btnMent.Size = new System.Drawing.Size(75, 23);
            this.btnMent.TabIndex = 7;
            this.btnMent.Text = "Mentés";
            this.btnMent.UseVisualStyleBackColor = true;
            this.btnMent.Click += new System.EventHandler(this.btnMent_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(557, 733);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(75, 23);
            this.btnTorles.TabIndex = 8;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 782);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnMent);
            this.Controls.Add(this.btnNyit);
            this.Controls.Add(this.tbxSzoveg);
            this.Controls.Add(this.btnKep);
            this.Controls.Add(this.pbKep);
            this.Controls.Add(this.gbxSzinezes);
            this.Name = "Form1";
            this.Text = "Dialogs";
            this.gbxSzinezes.ResumeLayout(false);
            this.gbxSzinezes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSzin;
        private System.Windows.Forms.Label lblSzinkod;
        private System.Windows.Forms.GroupBox gbxSzinezes;
        private System.Windows.Forms.Button btnSzinek;
        private System.Windows.Forms.PictureBox pbKep;
        private System.Windows.Forms.Button btnKep;
        private System.Windows.Forms.TextBox tbxSzoveg;
        private System.Windows.Forms.Button btnNyit;
        private System.Windows.Forms.Button btnMent;
        private System.Windows.Forms.Button btnTorles;
    }
}

