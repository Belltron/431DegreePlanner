using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegreePlanner
{
    public partial class additionalInfo : Form
    {
        public additionalInfo()
        {
            InitializeComponent();
        }

        public additionalInfo(Course course)
        {
            InitializeComponent();

            courseName.Text = "Course: " + course.Department + " " + course.CourseNum;
            courseHours.Text = "House: " + (course.Hours).ToString();
            courseDescription.Text = "Description: " + course.Description;
            coursePreReqs.Text = "Prerequisites: ";

        }
    }
}
