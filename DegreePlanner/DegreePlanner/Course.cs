using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreePlanner
{
    class Course
    {
        public string Description;
        public int CourseNum;
        public int Hours;
        public string PreReq;
        public string Deptartment;
        public Course()
        {
            this.Deptartment = "";
            this.Description = "";
            this.CourseNum = 0;
            this.PreReq = "";
            this.Hours = 0;
        }
        private string name;
        private List<Course> prerequisites;

        public Course(string n)
        {
            name = n;
        }

        public List<Course> getPrerequisites()
        {
            return prerequisites;
        }

        public override string ToString()    //called ToString so that the name representation is given in a listBox
        {
            return this.Deptartment + " " + this.CourseNum;
        }

        public void addPrerequisite(Course pre)
        {
            prerequisites.Add(pre);
        }
    }
}
