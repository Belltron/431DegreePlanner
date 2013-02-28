using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreePlanner
{
    enum YearEnum
    {
        Freshman = 0, Sophomore, Junior, Senior, SuperSenior, SuperDuperSenior
    }

    enum SemesterEnum
    {
        Fall = 0, Spring, Summer1, Summer2
    }
    
    class Course
    {
        public string Description;
        public int CourseNum;
        public int Hours;
        public string PreReq;
        public string Department;
        public YearEnum yearTaken;
        public SemesterEnum semesterTaken;

        public Course(string department, int courseNum, string description, int hours, string prereq)
        {
            this.Department = department;
            this.Description = description;
            this.CourseNum = courseNum;
            this.PreReq = prereq;
            this.Hours = hours;

        }

        public Course()
        {
            this.Department = "";
            this.Description = "";
            this.CourseNum = 0;
            this.PreReq = "";
            this.Hours = 0;
        }

        private string name;
        private List<Course> prerequisites;

        public List<Course> getPrerequisites()
        {
            return prerequisites;
        }

        public override string ToString()    //called ToString so that the name representation is given in a listBox
        {
            return this.Department + " " + this.CourseNum;
        }

        public void addPrerequisite(Course pre)
        {
            prerequisites.Add(pre);
        }

        public static bool operator ==(Course c1, Course c2)
        {
          
            try{
         
                if (((c1.Department) == (c2.Department)) && ((c1.CourseNum) == c2.CourseNum) && (c1.Description == c2.Description)
                    && (c1.Hours == c2.Hours) && (c1.PreReq == c2.PreReq))
                    return true;

                else return false;
            }
            catch (NullReferenceException) { return false; }                
       
        }

        public static bool operator !=(Course c1, Course c2)
        {
            return (!(c1 == c2));
        }

    }
}
