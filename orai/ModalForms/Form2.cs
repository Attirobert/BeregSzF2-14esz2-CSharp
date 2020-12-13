using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalForms
{
    public partial class FormAdat : Form
    {
        public FormAdat()
        {
            InitializeComponent();
        }

        public string getAzon()
        {
            return tbxAzon.Text;
        }

        public string getNev()
        {
            return tbxNev.Text;
        }

        public DateTime getSzulDat()
        {
            return dtpSzuletes.Value;
        }

        public void setAzon(string p)
        {
            tbxAzon.Text = p;
        }

        public void setNev(string p)
        {
            tbxNev.Text = p;
        }

        public void setSzulDatum(DateTime p)
        {
            dtpSzuletes.Value = p;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            tbxAzon.Clear();
            tbxNev.Clear();
            this.Hide();
        }
    }
}
