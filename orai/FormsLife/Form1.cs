using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLife
{
    public partial class frmFo : Form
    {
        Random rnd = new Random();

        // Képernyő felbontás
        private int felbX = 1600,
            felbY = 900;

        public frmFo()
        {
            InitializeComponent();
        }

        DateTime kezdido = new DateTime();


        private void btnGo_Click(object sender, EventArgs e)
        {
            tmrEgesz.Enabled = true;
            tmrEgesz.Interval = 120000;
            tmrUj.Enabled = true;
            tmrUj.Interval = 5000;
            kezdido = DateTime.Now;
        }

        private void tmrUj_Tick(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.lblEredm.Text = DateTime.Now.ToLongTimeString();
            frm.Top = rnd.Next() % felbY;
            frm.Left = rnd.Next() % felbX;

            frm.Show();
        }

        private void tmrEgesz_Tick(object sender, EventArgs e)
        {
            tmrEgesz.Stop();
            tmrUj.Stop();
        }

    }
}
