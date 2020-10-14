using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamKomp
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        double atlag;
        int osszeg,
            db,
            min = int.MaxValue,
            max = int.MinValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int i = random.Next(100) + 1;
            Label lbl = new Label();
            lbl.Location = new Point(e.X, e.Y);
            lbl.Text = i.ToString();
            lbl.AutoSize = true;
            Controls.Add(lbl);

            db++;
            osszeg += i;
            atlag = osszeg / (double)db;
            if (min > i)
            {
                min = i;
            }

            if (max < i)
            {
                max = i;
            }

            lblEredm.Text = String.Format("Darabszám: {0}, " +
                "összeg: {1}," +
                "átlag: {2}," +
                "Minimum: {3}," +
                "Maximum: {4}.",
                db, osszeg, atlag, min, max);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSzoveg.Text = "Kattintson az ablakon tetszőleges helyre!";
        }
    }
}
