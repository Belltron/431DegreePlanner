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
        Schedule schedule = new Schedule();

        public Form1()
        {
            Schedule schedule = new Schedule();

            List<Course> requiredCourses = sqlQuery.getAllCoursesFromTable("required_classes");
            List<Course> socialScienceCourses = sqlQuery.getAllCoursesFromTable("icd_sse");
            List<Course> performingArtsCourses = sqlQuery.getAllCoursesFromTable("icd_vpae");
            List<Course> scienceCourses = sqlQuery.getAllCoursesFromTable("science_classes");
            InitializeComponent();
            
            addSemester((SemesterEnum)0, (YearEnum)0);
            addSemester((SemesterEnum)1, (YearEnum)0);

            addSemester((SemesterEnum)0, (YearEnum)1);
            addSemester((SemesterEnum)1, (YearEnum)1);

            addSemester((SemesterEnum)0, (YearEnum)2);
            addSemester((SemesterEnum)1, (YearEnum)2);

            addSemester((SemesterEnum)0, (YearEnum)3);
            addSemester((SemesterEnum)1, (YearEnum)3);            

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

        private void addSemester(SemesterEnum id, YearEnum y)
        {
            Semester semester = new Semester(id,y);
            schedule.addSem(semester);

            semester.semesterBox.SetBounds(130*((int)id) + 75, 105*((int)y) + 60, 120, 95);
            this.Controls.Add(semester.semesterBox);
        }

        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            object itemToMove = e.Data.GetData(typeof(Course));
            Course course = (Course)itemToMove;
            if (course == null) { return; }

            course.semesterTaken = schedule.getSemester((sender as ListBox)).getID();
            course.yearTaken = schedule.getSemester((sender as ListBox)).getYear();

            (sender as ListBox).Items.Add(course);
            
            String output = "Added " + course.ToString() + " to semester " + course.semesterTaken + ", " + course.yearTaken;
            actionView.Items.Add(output);
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
            if(((sender as ListBox).SelectedItem) != null)
            {
                (sender as ListBox).DoDragDrop((sender as ListBox).SelectedItem, DragDropEffects.Move);
                (sender as ListBox).Items.Remove((sender as ListBox).SelectedItem);
                
            }
        }
            
    }
}
