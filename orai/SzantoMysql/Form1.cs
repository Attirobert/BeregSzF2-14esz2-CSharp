using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;


namespace SzantoMysql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "kiseloadas";

            MySqlConnection conn = new MySqlConnection(sb.ToString());
            conn.Open();

            MySqlCommand sql = new MySqlCommand();

            sql = conn.CreateCommand();

            // Beszúrás
            string nev = "Béla",
                email = "valamoi@valami.hu",
                jelszo = "akrmi",
                osszeg = "5000",
                status = "2";
            sql.CommandText = "insert into users ";
        }

        public void regisztral(string nev, string email, string jelszo)
        {
            // Insert 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
