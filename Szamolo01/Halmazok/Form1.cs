using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halmazok
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            HalmazGeneral(lbxA, Convert.ToInt32(nlA.Value));
            HalmazGeneral(lbxB, Convert.ToInt32(nlB.Value));
            Unio(lbxA, lbxB, lbxAuB);
            Metszet(lbxA, lbxB, lbxAmB);
            AminB(lbxA, lbxB, lbxAkB);
            BminA(lbxA, lbxB, lbxBkA);
        }

        private void HalmazGeneral(ListBox lbx, int n)
        {
            int elem;
            lbx.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                do
                {
                    elem = random.Next(n * 5);
                } while (BenneVan(lbx, elem));

                lbx.Items.Add(elem);
            }
        }

        private bool BenneVan(ListBox lbx, object elem)
        {
            for (int i = 0; i < lbx.Items.Count; i++)
            {
                if (lbx.Items[i].Equals(elem))
                {
                    return true;
                }
            }

            return false;
        }

        private void Unio(ListBox lbxA, ListBox lbxB, ListBox lbxU)
        {
            lbxU.Items.Clear();
            for (int i = 0; i < lbxA.Items.Count; i++)
            {
                lbxU.Items.Add(lbxA.Items[i]);
            }

            for (int i = 0; i < lbxB.Items.Count; i++)
            {
                if (!BenneVan(lbxU, lbxB.Items[i]))
                {
                    lbxU.Items.Add(lbxB.Items[i]);
                }
            }
        }

        private void Metszet(ListBox lbxA, ListBox lbxB, ListBox lbxM)
        {
            lbxM.Items.Clear();
            for (int i = 0; i < lbxA.Items.Count; i++)
            {
                if (BenneVan(lbxB, lbxA.Items[i]))
                {
                    lbxM.Items.Add(lbxA.Items[i]);
                }
            }
        }

        private void AminB(ListBox lbxA, ListBox lbxB, ListBox lbxAB)
        {
            lbxAB.Items.Clear();
            for (int i = 0; i < lbxA.Items.Count; i++)
            {
                if (!BenneVan(lbxB, lbxA.Items[i]))
                {
                    lbxAB.Items.Add(lbxA.Items[i]);
                }
            }
        }

        private void BminA(ListBox lbxA, ListBox lbxB, ListBox lbxBA)
        {
            lbxBA.Items.Clear();
            for (int i = 0; i < lbxB.Items.Count; i++)
            {
                if (!BenneVan(lbxA, lbxB.Items[i]))
                {
                    lbxBA.Items.Add(lbxB.Items[i]);
                }
            }
        }

    }
}
