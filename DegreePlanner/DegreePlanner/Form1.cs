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

            foreach(Control ctrl in this.Controls)
            {
                if (ctrl is ListBox)
                {
                    ctrl.MouseDown += new MouseEventHandler(listBox_MouseDown);
                    ctrl.DragOver += new DragEventHandler(listBox_DragOver);
                    ctrl.DragEnter += new DragEventHandler(listBox_DragEnter);
                    ctrl.DragDrop += new DragEventHandler(listBox_DragDrop);
                }
            }

            addHardCodedCourses();
        }

        private void button1_click(object sender, EventArgs e)      // still messy from testing
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
                result = reader.GetString(0) + " " + reader.GetString(1) + '\n';
                Course addCourse = new Course(result);
                courseBox.Items.Add(addCourse);
            }


            con.Close();
        }

        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            object itemToMove = e.Data.GetData(typeof(Course));
            if (itemToMove == null) { return; }

            (sender as ListBox).Items.Add(itemToMove);
        }

        private void listBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as ListBox).DoDragDrop((sender as ListBox).SelectedItem, DragDropEffects.Move);
        }

        private void addHardCodedCourses()
        {
            Course csce111 = new Course("CSCE 111");
            Course csce121 = new Course("CSCE 121");
            Course csce181 = new Course("CSCE 181");
            Course csce221 = new Course("CSCE 221");
            Course csce222 = new Course("CSCE 222");
            Course csce312 = new Course("CSCE 312");
            Course csce314 = new Course("CSCE 314");
            Course csce313 = new Course("CSCE 313");
            Course csce315 = new Course("CSCE 315");

            freshmanFall.Items.Add(csce111);

            freshmanSpring.Items.Add(csce121);
            freshmanSpring.Items.Add(csce181);

            sophomoreFall.Items.Add(csce221);
            sophomoreFall.Items.Add(csce222);

            sophomoreSpring.Items.Add(csce312);
            sophomoreSpring.Items.Add(csce314);

            juniorFall.Items.Add(csce313);
            juniorFall.Items.Add(csce315);
        }


    }
}
