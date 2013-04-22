using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DegreePlanner
{
    public enum YearEnum
    {
        Freshman = 0, Sophomore, Junior, Senior, SuperSenior, SuperDuperSenior
    }

    public enum SemesterEnum
    {
        Fall = 0, Spring, Summer1, Summer2
    }
    
    public class Course
    {
        public string Description;
        public int CourseNum;
        public int Hours;
        private List<Course> prerequisitesList;
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
            this.buildPreReqs();
       //     this.prerequisitesList = this.getPrerequisitesFromDatabase();
        }

        private void buildPreReqs()
        {
            if (PreReq != "" && PreReq != " ")
            {
                this.prerequisitesList = new List<Course>();
                List<String> preReqStrings = PreReq.Split(',').ToList();
                foreach (string preReqString in preReqStrings)
                {
                    String[] preReqDetails = preReqString.Trim().Split(' ');
                    this.prerequisitesList.Add(new Course(preReqDetails[0], Int32.Parse(preReqDetails[1]), "", 0, ""));
                }
            }
            else
            {
                this.prerequisitesList = new List<Course>();
            }
        }

        public List<Course> getPreRequisites()
        {
            return this.prerequisitesList;
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

        public List<Course> getPrerequisitesFromDatabase()
        {
            List<Course> rvalue = new List<Course>();
            if (this.PreReq == "")
                return rvalue;
            string[] preReqsArray = this.PreReq.Split(',');
            MySqlConnection con = sqlQuery.sqlConnect();
            foreach (string pr in preReqsArray)
            {
                List<string> splitCourseList = pr.Split(' ').ToList();
                if (splitCourseList.Count > 2)
                {
                    for (int i = 0; i < splitCourseList.Count; i++)
                    {
                        if (splitCourseList[i] == "")
                        {
                            splitCourseList.RemoveAt(i);
                            i--;
                        }
                    }
                }
                rvalue.Add(sqlQuery.getCourseByDeptCourseNum(con,splitCourseList[0],splitCourseList[1]));

            }
            sqlQuery.sqlClose(con);
            return rvalue;
        }

        public override string ToString()    //called ToString so that the name representation is given in a listBox
        {
            return this.Department + " " + this.CourseNum;
        }

        public void addPrerequisite(Course pre)
        {
            prerequisitesList.Add(pre);
        }

       /* public static bool operator ==(Course c1, Course c2)
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
        }*/

    }
}
