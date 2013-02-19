using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DegreePlanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_click(object sender, EventArgs e)
        {
            string connectionString = "Server=instance39020.db.xeround.com;Port=6887;Database=csv_db;Uid=admin;Pwd=password";
            MySqlConnection con = new MySqlConnection(connectionString);
            string query = "SELECT * FROM `tbl_name` WHERE COURSENUMBER = 271 LIMIT 0,30";
            MySqlCommand cmd = new MySqlCommand(query);
            MySqlDataReader reader = null;
            string result = null;
            con.Open();
            cmd.Connection = con;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result = reader.GetString(2) + '\n';
                textBox1.Text += result;
            }


            con.Close();
        }
    }
}
