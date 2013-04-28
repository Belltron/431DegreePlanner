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

            schedErrs.AddRange(ValidPreReqs(inp));
            schedErrs.AddRange(checkRequiredValidity(inp));
            schedErrs.AddRange(checkSpecificValidity(inp));
            schedErrs.AddRange(checkUpperLevelValidity(inp));
            schedErrs.AddRange(checkScienceValidity(inp));

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
            bool upperMath = false;

            foreach (Course req in requiredCourses)
            {
                bool requiredCheck = false;
                foreach (Semester s in semesters)
                {
                    foreach (Course cur in s.semesterBox.Items)
                    {
                        if (req.Department == cur.Department && req.CourseNum == cur.CourseNum) requiredCheck = true;
                        if ((cur.Department == "MATH" && cur.CourseNum == 304) || (cur.Department == "MATH" && cur.CourseNum == 308)) upperMath = true;
                    }
                }
                if (requiredCheck == false)
                {
                    string err = req.Department + " " + req.CourseNum.ToString() + " should be on your schedule";
                    scheduleErrors.Add(err);
                }
            }
            if (upperMath == false)
            {
                string mathErr = "Either MATH 304 or MATH 308 must be taken.";
                scheduleErrors.Add(mathErr);
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

            if (softwareCount < 3 && algCount < 3 && systemsCount < 3 && infoCount < 3)
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

        static public List<String> checkScienceValidity(Schedule input)
        {
            List<string> scheduleErrors = new List<string>();

            List<Course> chemistryOption = new List<Course>();
            List<Course> physicsOption = new List<Course>();
            List<Course> lifeSciencesOptionA = new List<Course>();
            List<Course> earthSciencesOptionA = new List<Course>();
            List<Course> lifeSciencesOptionB = new List<Course>();
            List<Course> earthSciencesOptionB = new List<Course>();

            List<Semester> semesters = input.getSemesters();

            List<Course> scienceCourses = sqlQuery.getAllCoursesFromTable("science_classes");

            Course chem101 = scienceCourses.SingleOrDefault(c => c.CourseNum == 101 && c.Department == ("CHEM"));
            Course chem111 = scienceCourses.SingleOrDefault(c => c.CourseNum == 111 && c.Department == ("CHEM"));
            Course chem102 = scienceCourses.SingleOrDefault(c => c.CourseNum == 102 && c.Department == ("CHEM"));
            Course chem112 = scienceCourses.SingleOrDefault(c => c.CourseNum == 112 && c.Department == ("CHEM"));
            chemistryOption.Add(chem101);
            chemistryOption.Add(chem111);
            chemistryOption.Add(chem102);
            chemistryOption.Add(chem112);
            

            Course phys218 = scienceCourses.SingleOrDefault(c => c.CourseNum == 218 && c.Department == ("PHYS"));
            Course phys208 = scienceCourses.SingleOrDefault(c => c.CourseNum == 208 && c.Department == ("PHYS"));
            physicsOption.Add(phys218);
            physicsOption.Add(phys208);


            Course biol111 = scienceCourses.SingleOrDefault(c => c.CourseNum == 111 && c.Department == ("BIOL"));
            Course biol112 = scienceCourses.SingleOrDefault(c => c.CourseNum == 112 && c.Department == ("BIOL"));
            lifeSciencesOptionA.Add(biol111);
            lifeSciencesOptionA.Add(biol112);

            Course biol101 = scienceCourses.SingleOrDefault(c => c.CourseNum == 101 && c.Department == ("BIOL"));
            Course biol107 = scienceCourses.SingleOrDefault(c => c.CourseNum == 107 && c.Department == ("BIOL"));
            lifeSciencesOptionB.Add(biol111);
            lifeSciencesOptionB.Add(biol101);
            lifeSciencesOptionB.Add(biol107);

            Course geol101 = scienceCourses.SingleOrDefault(c => c.CourseNum == 101 && c.Department == ("GEOL"));
            Course geol106 = scienceCourses.SingleOrDefault(c => c.CourseNum == 106 && c.Department == ("GEOL"));
            earthSciencesOptionA.Add(geol101);
            earthSciencesOptionA.Add(geol106);

            Course geol203 = scienceCourses.SingleOrDefault(c => c.CourseNum == 203 && c.Department == ("GEOL"));
            Course atmo201 = scienceCourses.SingleOrDefault(c => c.CourseNum == 201 && c.Department == ("ATMO"));
            Course atmo202 = scienceCourses.SingleOrDefault(c => c.CourseNum == 202 && c.Department == ("ATMO"));
            Course renr205 = scienceCourses.SingleOrDefault(c => c.CourseNum == 205 && c.Department == ("RENR"));
            Course renr215 = scienceCourses.SingleOrDefault(c => c.CourseNum == 215 && c.Department == ("RENR"));
            earthSciencesOptionB.Add(geol203);
            earthSciencesOptionB.Add(atmo201);
            earthSciencesOptionB.Add(atmo202);
            earthSciencesOptionB.Add(renr205);
            earthSciencesOptionB.Add(renr215);

           foreach (Semester s in semesters)
            {
                foreach (Course cur in s.semesterBox.Items)
                {
                    if (chemistryOption.Contains(cur)) chemistryOption.Remove(cur);
                    if (physicsOption.Contains(cur)) physicsOption.Remove(cur);
                    if (lifeSciencesOptionA.Contains(cur)) lifeSciencesOptionA.Remove(cur);
                    if (lifeSciencesOptionB.Contains(cur)) lifeSciencesOptionB.Remove(cur);
                    if (earthSciencesOptionA.Contains(cur)) earthSciencesOptionA.Remove(cur);
                    if (earthSciencesOptionB.Contains(cur)) earthSciencesOptionB.Remove(cur);
                }
            }

           Boolean chemBool = (chemistryOption.Count == 0);
           Boolean physBool = (physicsOption.Count == 0);
           Boolean lifeABool = (lifeSciencesOptionA.Count == 0);
           Boolean lifeBBool = (lifeSciencesOptionB.Count <= 1);
           Boolean earthABool = (earthSciencesOptionA.Count == 0);
           Boolean earthBBool;

           // atmo 201/201 and renr 205/215 should be taken
           if (earthSciencesOptionB.Contains(geol203))          
           {
               earthBBool = (earthSciencesOptionB.Count <= 1);
           }
           // geol 203 and renr 205/215 should be taken
           else if (earthSciencesOptionB.Contains(atmo201) || earthSciencesOptionB.Contains(atmo202))
           {
               earthBBool = ((earthSciencesOptionB.Count <= 2) && !(earthSciencesOptionB.Contains(renr205)) && !(earthSciencesOptionB.Contains(renr205)));
           }
           // geol 203 and atmo 201/202 should be taken
           else if (earthSciencesOptionB.Contains(renr205) || earthSciencesOptionB.Contains(renr215))
           {
               earthBBool = ((earthSciencesOptionB.Count <= 2) && !(earthSciencesOptionB.Contains(atmo201)) && !(earthSciencesOptionB.Contains(atmo202)));
           }
           // all have been taken, safe
           else earthBBool = (earthSciencesOptionB.Count == 0);

           // ACTUAL VALIDATION 
           /* Valid Possibilities:
            * chemBool = T, physBool = T
            * chemBool = T, lifeABool = T
            * chemBool = T, lifeBBool = T
            * chemBool = T, earthABool = T
            * chemBool = T, earthBBool = T
            * physBool = T, lifeABool = T
            * physBool = T, lifeBBool = T
            * physBool = T, earthABool = T
            * physBool = T, earthBBool = T
            * lifeABool = T, earthBBool = T
            * lifeBBool = T, earthABool = T
            */

           if (!((chemBool && physBool) || (chemBool && lifeABool) || (chemBool && lifeBBool) || (chemBool && earthABool) || (chemBool && earthBBool)
               || (physBool && lifeABool) || (physBool && lifeBBool) || (physBool && earthABool) || (physBool && earthBBool)
               || (lifeABool && earthBBool) || (lifeBBool && earthABool)))
           {
               string err = "Review the science courses and take the correct combination.";
               scheduleErrors.Add(err);
           }
            
           return scheduleErrors;
        }
    }
}
