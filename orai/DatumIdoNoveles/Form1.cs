using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatumIdoNoveles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            mtbIdo.Text = DateTime.Now.TimeOfDay.ToString();
        }

        private void Szamol(object sender, EventArgs e)
        {
            DateTime ido;
            try
            {
                ido = DateTime.ParseExact(mtbIdo.Text,
                    "HH:mm:ss",
                    CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Nincs megadva idő!");
                return;
            }

            DateTime ujDatumIdo = new DateTime(dtpDatum.Value.Year,
                dtpDatum.Value.Month,
                dtpDatum.Value.Day, ido.Hour, ido.Minute, ido.Second);

            Int32 noveles = (int)nudMenny.Value;

            if (cbxTipus.SelectedIndex == 0)
                ujDatumIdo = ujDatumIdo.AddYears((int)nudMenny.Value);

            if (cbxTipus.SelectedIndex == 1)
                ujDatumIdo = ujDatumIdo.AddMonths((int)nudMenny.Value);

            if (cbxTipus.SelectedIndex == 2)
                ujDatumIdo = ujDatumIdo.AddDays((int)nudMenny.Value);

            if (cbxTipus.SelectedIndex == 3)
                ujDatumIdo = ujDatumIdo.AddHours((int)nudMenny.Value);

            if (cbxTipus.SelectedIndex == 4)
                ujDatumIdo = ujDatumIdo.AddMinutes((int)nudMenny.Value);

            if (cbxTipus.SelectedIndex == 5)
                ujDatumIdo = ujDatumIdo.AddSeconds((int)nudMenny.Value);

            lblEredm.Text = String.Format("A növelt dátum és idő: {0}", ujDatumIdo);
        }
    }
}
