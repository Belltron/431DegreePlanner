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
            
    }
}
