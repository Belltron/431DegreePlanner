using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreePlanner
{
    static class ValidityChecker
    {
        static public List<String> checkGraduatingValidity(Schedule inp)
        {
            List<String> schedErrs = new List<string>();

            List<String> testerr = ValidPreReqs(inp);

            schedErrs.Concat(testerr);
            schedErrs.Concat(checkRequiredValidity(inp));
            schedErrs.Concat(checkSpecificValidity(inp));

            return schedErrs;
        }

        static public List<string> ValidPreReqs(Schedule input)
        {
            List<string> scheduleErrors = new List<string>();

            List<Semester> semesters = input.getSemesters();
            List<Course> coursesInSchedule = new List<Course>();
            //Build class list
            foreach (Semester semester in semesters)
            {
                foreach (Course course in semester.semesterBox.Items)
                {
                    Course tempCourse = course;
                    tempCourse.semesterTaken = semester.getID();
                    tempCourse.yearTaken = semester.getYear();
                    coursesInSchedule.Add(tempCourse);
                }
            }
            //Check for pre-reqs
            foreach (Course course in coursesInSchedule)
            {
                List<Course> preReqs = course.getPreRequisites();
                foreach (Course preReq in preReqs)
                {
                    //check if pre-req has been taken
                    // Sometimes error "has more than one matching element..."
                    Course tempClass =
                        coursesInSchedule.SingleOrDefault(
                            c => c.Department == preReq.Department && c.CourseNum == preReq.CourseNum);
                    if (tempClass == null)
                    {
                        string err = "Prerequisite " + preReq.Department + " " + preReq.CourseNum.ToString()
                                    + " for course " + course.Department + " " + course.CourseNum.ToString() + " is not on your schedule.";
                        scheduleErrors.Add(err);
                    }
                    //Check if taken in right year
                    else if (tempClass.yearTaken > course.yearTaken)
                    {
                        string err = preReq.Department + " " + preReq.CourseNum.ToString()
                         + " should be scheduled before " + course.Department + " " + course.CourseNum.ToString();
                        scheduleErrors.Add(err);
                    }
                    else if (tempClass.yearTaken == course.yearTaken && tempClass.semesterTaken >= course.semesterTaken)
                    {
                        string err = preReq.Department + " " + preReq.CourseNum.ToString()
                        + " should be scheduled before " + course.Department + " " + course.CourseNum.ToString();
                        scheduleErrors.Add(err);
                    }
                }
            }
            return scheduleErrors;
        }

        static public List<string> checkRequiredValidity(Schedule input)
        {
            List<Course> requiredCourses = sqlQuery.getAllCoursesFromTable("required_classes");

            List<Semester> semesters = input.getSemesters();
            List<string> scheduleErrors = new List<string>();

            foreach (Course req in requiredCourses)
            {
                bool requiredCheck = false;
                foreach (Semester s in semesters)
                {
                    foreach (Course cur in s.semesterBox.Items)
                    {
                        if (req.Department == cur.Department && req.CourseNum == cur.CourseNum) requiredCheck = true;
                    }
                }
                if (requiredCheck == false)
                {
                    string err = req.Department + " " + req.CourseNum.ToString() + " should be on your schedule";
                    scheduleErrors.Add(err);
                }
            }
            return scheduleErrors;
        }

        static public List<String> checkSpecificValidity(Schedule input)
        {
            List<Course> performingArtsCourses = sqlQuery.getAllCoursesFromTable("icd_vpae");
            List<Course> socialScienceCourses = sqlQuery.getAllCoursesFromTable("icd_sse");

            List<Semester> semesters = input.getSemesters();
            List<string> scheduleErrors = new List<string>();
            bool vpae = false;
            bool sse = false;

            foreach (Semester s in semesters)
            {
                foreach (Course cur in s.semesterBox.Items)
                {

                    //check to see if a performing arts course is on the schedule
                    if (vpae == false)
                    {
                        foreach (Course vpaeCourse in performingArtsCourses)
                        {
                            if (vpaeCourse.Department == cur.Department && vpaeCourse.CourseNum == cur.CourseNum)
                            {
                                vpae = true;
                                break;
                            }
                        }
                    }

                    //check to see if a social sciences course is on the schedule
                    if (sse == false)
                    {
                        foreach (Course sseCourse in socialScienceCourses)
                        {
                            if (sseCourse.Department == cur.Department && sseCourse.CourseNum == cur.CourseNum)
                            {
                                sse = true;
                                break;
                            }
                        }
                    }
                }                
            }
            if (vpae == false)
            {
                string vpaeErr = "You need a performing arts course on your schedule";
                scheduleErrors.Add(vpaeErr);
            }
            if (sse == false)
            {
                string sseErr = "You need a social sciences course on your schedule";
                scheduleErrors.Add(sseErr);
            }

            return scheduleErrors;
        }

        static public List<String> checkUpperLevelValidity(Schedule input)
        {
            List<Course> alg = sqlQuery.getAllCoursesFromTable("csce_algorithms_and_theory");
            List<Course> info = sqlQuery.getAllCoursesFromTable("csce_info_systems");
            List<Course> software = sqlQuery.getAllCoursesFromTable("csce_software");
            List<Course> systems = sqlQuery.getAllCoursesFromTable("csce_systems");

            int algCount = 0;
            int infoCount = 0;
            int softwareCount = 0;
            int systemsCount = 0;

            List<Semester> semesters = input.getSemesters();
            List<string> scheduleErrors = new List<string>();

            foreach (Semester s in semesters)
            {
                foreach (Course cur in s.semesterBox.Items)
                {
                    if ("CSCE" == cur.Department && 411 == cur.CourseNum) algCount += 1;
                     foreach(Course algCourse in alg)
                     {
                         if (algCourse.Department == cur.Department && algCourse.CourseNum == cur.CourseNum) algCount += 1;                         
                     }

                     foreach (Course infoCourse in info)
                     {
                         if (infoCourse.Department == cur.Department && infoCourse.CourseNum == cur.CourseNum) infoCount += 1;
                     }

                     foreach (Course softwareCourse in software)
                     {
                         if (softwareCourse.Department == cur.Department && softwareCourse.CourseNum == cur.CourseNum) softwareCount += 1;
                     }

                     foreach (Course systemsCourse in systems)
                     {
                         if (systemsCourse.Department == cur.Department && systemsCourse.CourseNum == cur.CourseNum) systemsCount += 1;
                     }
                }
            }

            if (algCount == 0)
            {
                string algErr = "At lease one course in the Algorithms track is required";
                scheduleErrors.Add(algErr);
            }

            if (infoCount == 0)
            {
                string algErr = "At lease one course in the Information and Intelligent Systems track is required";
                scheduleErrors.Add(algErr);
            }

            if (systemsCount == 0)
            {
                string algErr = "At lease one course in the Systems track is required";
                scheduleErrors.Add(algErr);
            }

            if (softwareCount == 0)
            {
                string algErr = "At lease one course in the Software track is required";
                scheduleErrors.Add(algErr);
            }

            if (softwareCount < 3 && algCount < 3 && systemsCount < 3 && softwareCount < 3)
            {
                string threeErr = "At lease three courses from one track must be taken";
                scheduleErrors.Add(threeErr);
            }

            if ((algCount + systemsCount + softwareCount + infoCount) < 7)
            {
                string totalErr = "You must take CSCE 411 and 6 upper level courses";
                scheduleErrors.Add(totalErr);
            }

            return scheduleErrors;
        }
    }
}
