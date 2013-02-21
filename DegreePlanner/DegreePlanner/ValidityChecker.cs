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
            foreach (Course course in input.Courses)
            {
                if (course.PreReq != "")
                {
                    string[] preReqs = course.PreReq.Split(',');
                    foreach (string preReq in preReqs)
                    {
                        Course tempCourse =
                        input.Courses.Find(c => (preReq.Contains(c.Deptartment)) && preReq.Contains(c.CourseNum.ToString()));
                        //Pre Req not taken at all
                        if (tempCourse == null)
                        {
                            return false;
                        }
                        //Pre Req is taken at right time
                        else if ((tempCourse.yearTaken < course.yearTaken) ||
                                 ((tempCourse.yearTaken == course.yearTaken) &&
                                  tempCourse.semesterTaken < course.semesterTaken))
                        {
                            validPreReqs = true;
                        }
                        //Pre Req not taken before class
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return validPreReqs;
        }
    }
}
