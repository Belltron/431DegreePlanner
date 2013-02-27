using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegreePlanner
{
    class Schedule
    {
     //   public List<Course> Courses = new List<Course>();
        private List<Semester> semesters = new List<Semester>();

        public void addSem(Semester s)
        {
                semesters.Add(s);
        }

        public Semester getSemester(ListBox lb)
        {
            /*
             This code can be replaced with these two lines
             * It returns the semester if its there or it returns a blank semester
             
            Semester rvalue = semesters.SingleOrDefault(s => s.semesterBox == lb);
            return rvalue ?? new Semester();
             * 
             */
            foreach (Semester s in semesters)
            {
                if (s.getSemesterBox() == lb)
                {
                    return s;
                }
            }
            return semesters[1];    // should return error here, this is here now for testing
        }

        public List<Semester> getSemesters()
        {
            return semesters;
        }

      /*  public void addCourse(Course c)
        {
            if (Courses.Count > 0)
            {
                for (int i = 0; i < Courses.Count(); i++)        //course already exists
                {
               //     if (c == Courses[i]) return;
                }
            }

            Courses.Add(c);
        }*/
        
    }
}
