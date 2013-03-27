using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreePlanner
{
    class FileSystem
    {
        System.IO.StreamWriter Fall1 = new System.IO.StreamWriter("Fall1.txt");
        System.IO.StreamWriter Spring1 = new System.IO.StreamWriter("Spring1.txt");
        System.IO.StreamWriter Summer1 = new System.IO.StreamWriter("Summer1.txt");
        System.IO.StreamWriter Fall2 = new System.IO.StreamWriter("Fall2.txt");
        System.IO.StreamWriter Spring2 = new System.IO.StreamWriter("Spring2.txt");
        System.IO.StreamWriter Summer2 = new System.IO.StreamWriter("Summer2.txt");
        System.IO.StreamWriter Fall3 = new System.IO.StreamWriter("Fall3.txt");
        System.IO.StreamWriter Spring3 = new System.IO.StreamWriter("Spring3.txt");
        System.IO.StreamWriter Summer3 = new System.IO.StreamWriter("Summer3.txt");
        System.IO.StreamWriter Fall4 = new System.IO.StreamWriter("Fall4.txt");
        System.IO.StreamWriter Spring4 = new System.IO.StreamWriter("Spring4.txt");
        System.IO.StreamWriter Summer4 = new System.IO.StreamWriter("Summer4.txt");

        public void writeToFile(Schedule schedule)
        {
            foreach (Semester s in schedule.getSemesters())
            {
                if (s.ID == SemesterEnum.Fall && s.year == YearEnum.Freshman)
                {
                    string classes = "";
                    foreach (Course c in s.getSemesterBox().Items)
                    {
                        classes += c.Department + ' ' + c.CourseNum + ' ' + c.Description + ' ' + c.Hours + ' ' + c.PreReq + "\n";
                    }
                    Fall1.WriteLine(classes);
                    Fall1.Close();
                }
                else if (s.ID == SemesterEnum.Spring && s.year == YearEnum.Freshman)
                {
                    string classes = "";
                    foreach (Course c in s.getSemesterBox().Items)
                    {
                        classes += c.Department + ' ' + c.CourseNum + ' ' + c.Description + ' ' + c.Hours + ' ' + c.PreReq + "\n";
                    }
                    Spring1.WriteLine(classes);
                    Spring1.Close();
                }
                else if (s.ID == SemesterEnum.Fall && s.year == YearEnum.Sophomore)
                {
                    string classes = "";
                    foreach (Course c in s.getSemesterBox().Items)
                    {
                        classes += c.Department + ' ' + c.CourseNum + ' ' + c.Description + ' ' + c.Hours + ' ' + c.PreReq + "\n";
                    }
                    Fall2.WriteLine(classes);
                    Fall2.Close();

                }
                else if (s.ID == SemesterEnum.Spring && s.year == YearEnum.Sophomore)
                {
                    string classes = "";
                    foreach (Course c in s.getSemesterBox().Items)
                    {
                        classes += c.Department + ' ' + c.CourseNum + ' ' + c.Description + ' ' + c.Hours + ' ' + c.PreReq + "\n";
                    }
                    Spring2.WriteLine(classes);
                    Spring2.Close();
                }
                else if (s.ID == SemesterEnum.Fall && s.year == YearEnum.Junior)
                {
                    string classes = "";
                    foreach (Course c in s.getSemesterBox().Items)
                    {
                        classes += c.Department + ' ' + c.CourseNum + ' ' + c.Description + ' ' + c.Hours + ' ' + c.PreReq + "\n";
                    }
                    Fall3.WriteLine(classes);
                    Fall3.Close();
                }
                else if (s.ID == SemesterEnum.Spring && s.year == YearEnum.Junior)
                {
                    string classes = "";
                    foreach (Course c in s.getSemesterBox().Items)
                    {
                        classes += c.Department + ' ' + c.CourseNum + ' ' + c.Description + ' ' + c.Hours + ' ' + c.PreReq + "\n";
                    }
                    Spring3.WriteLine(classes);
                    Spring3.Close();
                }
                else if (s.ID == SemesterEnum.Fall && s.year == YearEnum.Senior)
                {
                    string classes = "";
                    foreach (Course c in s.getSemesterBox().Items)
                    {
                        classes += c.Department + ' ' + c.CourseNum + ' ' + c.Description + ' ' + c.Hours + ' ' + c.PreReq + "\n";
                    }
                    Fall4.WriteLine(classes);
                    Fall4.Close();
                }
                else if (s.ID == SemesterEnum.Spring && s.year == YearEnum.Senior)
                {
                    string classes = "";
                    foreach (Course c in s.getSemesterBox().Items)
                    {
                        classes += c.Department + ' ' + c.CourseNum + ' ' + c.Description + ' ' + c.Hours + ' ' + c.PreReq + "\n";
                    }
                    Spring4.WriteLine(classes);
                    Spring4.Close();
                }
            }
        }
    }
}
