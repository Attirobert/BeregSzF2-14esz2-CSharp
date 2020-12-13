using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ModalForms
{
    public partial class frmFo : Form
    {
        FormAdat frm = new FormAdat();

        public frmFo()
        {
            InitializeComponent();
            frm.Hide();
        }

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
            if (frm.getNev() != "")
            {
                ListViewItem lvi;
                lvi = ltvAdatok.Items.Add(frm.getNev());
                lvi.SubItems.Add(frm.getAzon());
                lvi.SubItems.Add(frm.getSzulDat().ToString());
            }
        }

        private void frmFo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan kilép?", "Kérdés",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) e.Cancel = true;
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            // Ellenőrizzük, hogy van-e kijelölt elem
            if (ltvAdatok.SelectedItems.Count >0)
            {
                // Adat form feltöltése
                frm.setNev(ltvAdatok.SelectedItems[0].Text);
                frm.setAzon(ltvAdatok.SelectedItems[0].SubItems[1].Text);
                frm.setSzulDatum(Convert.ToDateTime(ltvAdatok.SelectedItems[0].SubItems[2].Text));

                // Megjelenítjük és az eredményt visszaírjuk
                frm.ShowDialog();
                if (frm.getNev() != "")
                {
                    ltvAdatok.SelectedItems[0].Text = frm.getNev();
                    ltvAdatok.SelectedItems[0].SubItems[1].Text = frm.getAzon();
                    ltvAdatok.SelectedItems[0].SubItems[2].Text = frm.getSzulDat().ToString();
                }

            }


        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ltvAdatok.SelectedItems.Count-1; i++)
            {
                ltvAdatok.Items.Remove(ltvAdatok.SelectedItems[0]);
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BinaryWriter br = new BinaryWriter(File.Open(sfd.FileName, FileMode.Create));
                try
                {
                    int i;
                    for (i = 0; i < ltvAdatok.Items.Count; i++)
                    {
                        br.Write(ltvAdatok.Items[i].Text); 
                        br.Write(ltvAdatok.Items[i].SubItems[1].Text);
                        br.Write(ltvAdatok.Items[i].SubItems[2].Text);
                    }
                    br.Flush();
                }
                catch
                {
                    MessageBox.Show("Hiba a mentésben.");
                }
                finally
                {
                    br.Close();
                }
            }
        }

        private void btnFajlbol_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                ltvAdatok.Items.Clear();
                BinaryReader br = new BinaryReader(File.Open(of.FileName, FileMode.Open));

                try
                {
                    if (File.Exists(of.FileName))
                    {
                        long len1 = br.BaseStream.Length; 
                        while (br.BaseStream.Position < len1)
                        {
                            ListViewItem li = new ListViewItem(br.ReadString()); 
                            li.SubItems.Add(br.ReadString());
                            li.SubItems.Add(br.ReadString()); 

                            ltvAdatok.Items.Add(li);
                        }
                    }
                }
                catch {
                    MessageBox.Show("Hiba a fájlban");
                }
                finally
                {
                    br.Close();
                }
            }
        }
    }
}
