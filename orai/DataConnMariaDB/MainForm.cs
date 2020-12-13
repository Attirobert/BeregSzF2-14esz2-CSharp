using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataConnMariaDB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            string strConnect = "SERVER=localhost;DATABASE=iktato;UID=root;PASSWORD=;";
            MySqlConnection _con = new MySqlConnection(strConnect);
            DataTable _table = new DataTable();
            MySqlDataAdapter _adp = new MySqlDataAdapter("select * from users", _con);
            _adp.Fill(_table);

            dataGridView1.DataSource = _table;
        }
    }
}
