using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formazas
{
    public partial class Form1 : Form
    {
        Color szin = Color.Red;
        string betűtípus = "Arial";
        int betűméret = 12;
        FontStyle stilus = FontStyle.Regular;


        public Form1()
        {
            InitializeComponent();

            // Kezdeti értékek beállítása
            cbxValaszt.Items.Add("Szöveg");
            cbxValaszt.Items.Add("Háttér");
            cbxValaszt.SelectedIndex = 0;

            nudMeret.Minimum = 8;
            nudMeret.Maximum = 36;
            nudMeret.Increment = 2;
            nudMeret.Value = betűméret;

            rtbSzoveg.Text = "Próba";
            rtbSzoveg.Font = new Font(betűtípus, betűméret, stilus);
            rtbSzoveg.ForeColor = Color.Red;
            rtbSzoveg.BackColor = Color.LightGreen;

            rbPiros.Checked = true;
            rbDolt.Checked = true;
            rbArial.Checked = true;

            Beallit(cbxValaszt.SelectedIndex == 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Beallit(cbxValaszt.SelectedIndex == 0);
        }

        private void cbxValaszt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Beallit(cbxValaszt.SelectedIndex == 0);
        }

        private void Beallit(bool a)
        {
            rbfelkover.Enabled = a;
            rbDolt.Enabled = a;
            rbAlahuzott.Enabled = a;

            rbArial.Enabled = a;
            rbComics.Enabled = a;
            rbTnr.Enabled = a;
            nudMeret.Enabled = a;
        }

        private void szovegStyle()
        {
            if (rbArial.Checked) betűtípus = "Arial";
            if (rbTnr.Checked) betűtípus = "Times New Roman";
            if (rbComics.Checked) betűtípus = "Comic Sans";

            if (rbKek.Checked) szin = Color.Blue;
            if (rbPiros.Checked) szin = Color.Red;
            if (rbZold.Checked) szin = Color.Green;

            betűméret = Convert.ToInt32(nudMeret.Value);

            if (rbfelkover.Checked) stilus = FontStyle.Bold;
            if (rbDolt.Checked) stilus = FontStyle.Italic;
            if (rbAlahuzott.Checked) stilus = FontStyle.Underline;

            rtbSzoveg.Font = new Font(betűtípus, betűméret, stilus);
            rtbSzoveg.ForeColor = szin;
        }

        private void btnAlkalmaz_Click(object sender, EventArgs e)
        {
            if (cbxValaszt.SelectedIndex==0) szovegStyle();
            else hatterStyle();
        }

        private void hatterStyle()
        {
            if (rbKek.Checked) szin = Color.Blue;
            if (rbPiros.Checked) szin = Color.Red;
            if (rbZold.Checked) szin = Color.Green;
            rtbSzoveg.BackColor = szin;
        }
    }
}
