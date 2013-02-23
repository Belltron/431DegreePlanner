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
            sqlQuery query = new sqlQuery();
            List<Course> requiredCourses = query.getAllCoursesFromTable("required_classes");
            List<Course> socialScienceCourses = query.getAllCoursesFromTable("icd_sse");
            List<Course> performingArtsCourses = query.getAllCoursesFromTable("icd_vpae");
            List<Course> scienceCourses = query.getAllCoursesFromTable("science_classes");
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

            foreach (Course c in requiredCourses)
            {
                requiredCoursesBox.Items.Add(c);
            }

            foreach (Course c in socialScienceCourses)
            {
                socialScienceBox.Items.Add(c);
            }

            foreach (Course c in performingArtsCourses)
            {
                performingArtsBox.Items.Add(c);
            }

            foreach (Course c in scienceCourses)
            {
                scienceBox.Items.Add(c);
            }

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
            (sender as ListBox).Items.Remove((sender as ListBox).SelectedItem);
        }

        private void getRequiredCourses()
        {
            /*Course csce111 = new Course("CSCE", 111, "", );
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
            juniorFall.Items.Add(csce315);*/
        }


    }
}
