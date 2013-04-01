using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreePlanner
{
    static class ValidityChecker
    {
        static public bool ValidPreReqs(Schedule input)
        {
            bool validPreReqs = true;
            List<Semester> semesters = input.getSemesters();
            List<Course> coursesInSchedual = new List<Course>();
            //Build class list
            foreach (Semester semester in semesters)
            {
                foreach (Course course in semester.semesterBox.Items)
                {
                    Course tempCourse = course;
                    tempCourse.semesterTaken = semester.getID();
                    tempCourse.yearTaken = semester.getYear();
                    coursesInSchedual.Add(tempCourse);
                }
            }
            //Check for pre-reqs
            foreach (Course course in coursesInSchedual)
            {
                List<Course> preReqs = course.getPreRequisites();
                foreach (Course preReq in preReqs)
                {
                    //check if pre-req has been taken
                    Course tempClass =
                        coursesInSchedual.SingleOrDefault(
                            c => c.Department == preReq.Department && c.CourseNum == preReq.CourseNum);
                    if (tempClass == null)
                    {
                        return false;
                    }
                    //Check if taken in right year
                    else if (tempClass.yearTaken > course.yearTaken)
                    {
                        return false;
                    }
                    else if (tempClass.yearTaken == course.yearTaken && tempClass.semesterTaken >= course.semesterTaken)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
