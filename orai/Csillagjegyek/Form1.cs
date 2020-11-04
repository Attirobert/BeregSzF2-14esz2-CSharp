using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csillagjegyek
{
    public partial class Form1 : Form
    {
        public struct csillJegy
        {
            public string nev;
            public int nap;
        }

        private csillJegy[] c = new csillJegy[13];

        public Form1()
        {
            InitializeComponent();


            c[1].nev = "Vízöntő";
            c[1].nap = 20;

            c[2].nev = "Halak";
            c[2].nap = 19;

            c[3].nev = "Kos";
            c[3].nap = 21;

            c[4].nev = "Bika";
            c[4].nap = 20;

            c[5].nev = "Ikrek";
            c[5].nap = 21;

            c[6].nev = "Rák";
            c[6].nap = 22;

            c[7].nev = "Oroszlán";
            c[7].nap = 23;

            c[8].nev = "Szűz";
            c[8].nap = 23;

            c[9].nev = "Mérleg";
            c[9].nap = 23;

            c[10].nev = "Skorpió";
            c[10].nap = 23;

            c[11].nev = "Nyilas";
            c[11].nap = 22;

            c[12].nev = "Bak";
            c[12].nap = 22;

            c[0].nev = "Bak";
            // c[0].nap = 22;
        }

        private void dtpSzul_ValueChanged(object sender, EventArgs e)
        {
            int a = dtpSzul.Value.Month;
            lblEredm.Text = String.Format("Az Ön csillagjegye: {0}",
    (dtpSzul.Value.Day < c[a].nap) ? c[a - 1].nev : c[a].nev);

        }
    }
}
