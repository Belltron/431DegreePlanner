﻿using System;
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
        FileSystem f = new FileSystem();
        List<Course> socialScienceCourses = sqlQuery.getAllCoursesFromTable("icd_sse");
        List<Course> performingArtsCourses = sqlQuery.getAllCoursesFromTable("icd_vpae");
        List<Course> scienceCourses = sqlQuery.getAllCoursesFromTable("science_classes");
        List<Course> allCsCourses = sqlQuery.getAllCoursesFromTable("csce_all");
        List<Course> requiredCourses = sqlQuery.getAllCoursesFromTable("required_classes");
        List<string> departmentList = sqlQuery.getDepartments();

        public Form1()
        {
            Image image = Image.FromFile(@"C:\Users\Brian\Pictures\backgrounds\atm.jpg");
            this.BackgroundImage = image;        

            InitializeComponent();

            departmentBox.Sorted = true;
            requiredCoursesBox.Sorted = true;

            foreach (string s in departmentList)
            {
                departmentBox.Items.Add(s);
            }
            
            addSemester((SemesterEnum)0, (YearEnum)0);
            addSemester((SemesterEnum)1, (YearEnum)0);

            addSemester((SemesterEnum)0, (YearEnum)1);
            addSemester((SemesterEnum)1, (YearEnum)1);

            addSemester((SemesterEnum)0, (YearEnum)2);
            addSemester((SemesterEnum)1, (YearEnum)2);

            addSemester((SemesterEnum)0, (YearEnum)3);
            addSemester((SemesterEnum)1, (YearEnum)3);
            schedule = f.readFromFile(schedule);

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

            if ((sender as ListBox).Items.Count <= 5)
            {
                (sender as ListBox).Items.Add(course);
            }
            else
            {
                scheduleCheckOutput numItemErr = new scheduleCheckOutput("A semester should contain at most 6 courses");
                numItemErr.Show();
            }
          //  String output = "Added " + course.ToString() + " to semester " + course.semesterTaken + ", " + course.yearTaken;
           // actionView.Items.Add(output);
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
            (sender as ListBox).SelectedIndex = (sender as ListBox).IndexFromPoint(e.X, e.Y);

            if (e.Button == MouseButtons.Right)         // right click
            {
                Course c = new Course();
                c = (Course)(sender as ListBox).SelectedItem;
                ContextMenuStrip cms = new ContextMenuStrip();
                string moreInfo = "More Information...";
                string remove = "Remove";
                
                ToolStripMenuItem getMoreInfo = new ToolStripMenuItem(moreInfo);
                ToolStripMenuItem removeCourse = new ToolStripMenuItem(remove);
               
                getMoreInfo.Click += new EventHandler((fake,d) => moreCourseInfoClick(fake,d,c));
                removeCourse.Click += new EventHandler((fake, d) => removeCourseClick(fake, d, (sender as ListBox),c));


                cms.Items.AddRange(new ToolStripItem[] {getMoreInfo});
                cms.Items.AddRange(new ToolStripItem[] { removeCourse });
                cms.Visible = true;
                cms.SetBounds(Cursor.Position.X, Cursor.Position.Y, 50, 50);
                if (this.ParentForm != null)
                {
                    this.ParentForm.Controls.Add(cms);
                }                
            }

            else if(((sender as ListBox).SelectedItem) != null)          //drag
            {
                (sender as ListBox).DoDragDrop((sender as ListBox).SelectedItem, DragDropEffects.Move);

                if ((sender as ListBox) != requiredCoursesBox) // only delete items in semester boxes
                {
                    (sender as ListBox).Items.Remove((sender as ListBox).SelectedItem);
                }
                
            }
        }

        private void moreCourseInfoClick(object sender, EventArgs e, Course course)
        {
            try
            {
                additionalInfo ad = new additionalInfo(course);
                ad.Show();
            }
            catch (NullReferenceException) { }
        }

        private void removeCourseClick(object sender, EventArgs e, ListBox lb, Course course)
        {
            try
            {                
                lb.Items.Remove(course);
            }
            catch (NullReferenceException) { };
        }

        private void BaseSchedule_Click(object sender, EventArgs e)
        {
            List<Semester> semesters = schedule.getSemesters();
            foreach (Semester s in semesters)
            {
                if (s.ID == SemesterEnum.Fall && s.year == YearEnum.Freshman)
                {
                    //s.semesterBox.Items.Add( element in requiredcourses list where element.CourseNum = 121 and element.Department = CSCE
                    Course csce121 = requiredCourses.SingleOrDefault(c => c.CourseNum == 121 && c.Department == ("CSCE"));
                    s.semesterBox.Items.Add(csce121);

                    Course csce181 = requiredCourses.SingleOrDefault(c => c.CourseNum == 181 && c.Department == ("CSCE"));
                    s.semesterBox.Items.Add(csce181);

                    Course engl104 = requiredCourses.SingleOrDefault(c => c.CourseNum == 104 && c.Department == ("ENGL"));
                    s.semesterBox.Items.Add(engl104);

                    Course math151 = requiredCourses.SingleOrDefault(c => c.CourseNum == 151 && c.Department == ("MATH"));
                    s.semesterBox.Items.Add(math151);
                }
                else if (s.ID == SemesterEnum.Spring && s.year == YearEnum.Freshman)
                {
                    Course csce221 = requiredCourses.SingleOrDefault(c => c.CourseNum == 221 && c.Department == ("CSCE"));
                    s.semesterBox.Items.Add(csce221);

                    Course csce222 = requiredCourses.SingleOrDefault(c => c.CourseNum == 222 && c.Department == ("CSCE"));
                    s.semesterBox.Items.Add(csce222);

                    Course math152 = requiredCourses.SingleOrDefault(c => c.CourseNum == 152 && c.Department == ("MATH"));
                    s.semesterBox.Items.Add(math152);

                    Course kine198 = requiredCourses.SingleOrDefault(c => c.CourseNum == 198 && c.Department == ("KINE"));
                    s.semesterBox.Items.Add(kine198);
                }
                else if (s.ID == SemesterEnum.Fall && s.year == YearEnum.Sophomore)
                {
                    Course csce312 = requiredCourses.SingleOrDefault(c => c.CourseNum == 312 && c.Department == ("CSCE"));
                    s.semesterBox.Items.Add(csce312);

                    Course csce314 = requiredCourses.SingleOrDefault(c => c.CourseNum == 314 && c.Department == ("CSCE"));
                    s.semesterBox.Items.Add(csce314);

                    Course math302 = requiredCourses.SingleOrDefault(c => c.CourseNum == 302 && c.Department == ("MATH"));
                    s.semesterBox.Items.Add(math302);

                    Course pols206 = requiredCourses.SingleOrDefault(c => c.CourseNum == 206 && c.Department == ("POLS"));
                    s.semesterBox.Items.Add(pols206);
                }
                else if (s.ID == SemesterEnum.Spring && s.year == YearEnum.Sophomore)
                {
                    Course csce313 = requiredCourses.SingleOrDefault(c => c.CourseNum == 313 && c.Department == ("CSCE"));
                    s.semesterBox.Items.Add(csce313);

                    Course csce315 = requiredCourses.SingleOrDefault(c => c.CourseNum == 315 && c.Department == ("CSCE"));
                    s.semesterBox.Items.Add(csce315);

                    Course stat211 = requiredCourses.SingleOrDefault(c => c.CourseNum == 211 && c.Department == ("STAT"));
                    s.semesterBox.Items.Add(stat211);

                    Course pols207 = requiredCourses.SingleOrDefault(c => c.CourseNum == 207 && c.Department == ("POLS"));
                    s.semesterBox.Items.Add(pols207);
                }
                else if (s.ID == SemesterEnum.Fall && s.year == YearEnum.Junior)
                {
                    Course csce481 = requiredCourses.SingleOrDefault(c => c.CourseNum == 481 && c.Department == ("CSCE"));
                    s.semesterBox.Items.Add(csce481);
                }
                else if (s.ID == SemesterEnum.Spring && s.year == YearEnum.Junior)
                {
                    Course csce411 = requiredCourses.SingleOrDefault(c => c.CourseNum == 411 && c.Department == ("CSCE"));
                    s.semesterBox.Items.Add(csce411);
                }
                else if (s.ID == SemesterEnum.Fall && s.year == YearEnum.Senior)
                {
                    Course kine199 = requiredCourses.SingleOrDefault(c => c.CourseNum == 199 && c.Department == ("KINE"));
                    s.semesterBox.Items.Add(kine199);
                }
                else if (s.ID == SemesterEnum.Spring && s.year == YearEnum.Senior)
                {
                    Course csce482 = requiredCourses.SingleOrDefault(c => c.CourseNum == 482 && c.Department == ("CSCE"));
                    s.semesterBox.Items.Add(csce482);

                    Course engr482 = requiredCourses.SingleOrDefault(c => c.CourseNum == 482 && c.Department == ("ENGR"));
                    s.semesterBox.Items.Add(engr482);
                }
            }
            BaseSchedule.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.writeToFile(schedule);
        }

        private void scheduleReset(object sender, EventArgs e)
        {
            try
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is ListBox)
                    {
                        (ctrl as ListBox).Items.Clear();
                    }
                }
            }
            catch (NullReferenceException) { }

            BaseSchedule.Show();
        }

        private void requiredCoursesClick(object sender, EventArgs e)
        {
            requiredCoursesBox.Items.Clear();

            foreach (Course c in requiredCourses)
            {
                requiredCoursesBox.Items.Add(c);
            }
        }

        private void computerScienceClick(object sender, EventArgs e)
        {
            requiredCoursesBox.Items.Clear();

            foreach (Course c in allCsCourses)
            {
                requiredCoursesBox.Items.Add(c);
            }
        }

        private void socialSciencesClick(object sender, EventArgs e)
        {
            requiredCoursesBox.Items.Clear();

            foreach (Course c in socialScienceCourses)
            {
                requiredCoursesBox.Items.Add(c);
            }
        }

        private void sciencesClick(object sender, EventArgs e)
        {
            requiredCoursesBox.Items.Clear();

            foreach (Course c in scienceCourses)
            {
                requiredCoursesBox.Items.Add(c);
            }
        }

        private void performingArtsClick(object sender, EventArgs e)
        {
            requiredCoursesBox.Items.Clear();

            foreach (Course c in performingArtsCourses)
            {
                requiredCoursesBox.Items.Add(c);
            }
        }

        private void checkSchedule(object sender, EventArgs e)
        {
         //   Boolean valid = ValidityChecker.ValidPreReqs(this.schedule);
            //List<string> errors = ValidityChecker.ValidPreReqs(this.schedule);
            //List<string> errors = ValidityChecker.checkGraduatingValidity(this.schedule);
           // List<string> errors = ValidityChecker.checkSpecificValidity(this.schedule);
            List<string> errors = ValidityChecker.checkUpperLevelValidity(this.schedule);
            if (errors.Count == 0)
            {
                try
                {
                    scheduleCheckOutput sco = new scheduleCheckOutput("Your Schedule is Valid");
                    sco.Show();
                }
                catch (NullReferenceException) { }
            }
            else
            {
                try
                {
                    scheduleCheckOutput sco = new scheduleCheckOutput(errors);
                    sco.Show();
                }
                catch (NullReferenceException) { }
            }
        }

        private void departmentClick(object sender, EventArgs e)
        {
            try
            {
                string dept = departmentBox.SelectedItem.ToString();

                List<Course> departmentCourses = sqlQuery.getCoursesByDepartment(dept);

                requiredCoursesBox.Items.Clear();

                foreach (Course c in departmentCourses)
                {
                    requiredCoursesBox.Items.Add(c);
                }
            }
            catch (NullReferenceException) { };
        }
           
    }
}
