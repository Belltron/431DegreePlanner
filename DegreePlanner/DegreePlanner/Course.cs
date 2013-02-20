using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreePlanner
{
    class Course
    {
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
            return name;
        }

        public void addPrerequisite(Course pre)
        {
            prerequisites.Add(pre);
        }
    }
}
