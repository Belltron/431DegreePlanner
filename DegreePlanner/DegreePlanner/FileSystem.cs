using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DegreePlanner
{
    class FileSystem
    {



        public void writeToFile(Schedule schedule)
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
            foreach (Semester s in schedule.getSemesters())
            {
                if (s.ID == SemesterEnum.Fall && s.year == YearEnum.Freshman)
                {
                    string classes = "";
                    foreach (Course c in s.getSemesterBox().Items)
                    {
                        if(c.Description == ""){
                            c.Description = "NoDesc"; 
                        }
                        if(c.PreReq == ""){
                            c.PreReq = "NoPre";
                        }
                        classes += c.Department + '|' + c.CourseNum + '|' + c.Description + '|' + c.Hours + '|' + c.PreReq + "\n";
                    }
                    classes = classes.TrimEnd('\r', '\n');
                    Fall1.Write(classes);
                    Fall1.Close();
                }
                else if (s.ID == SemesterEnum.Spring && s.year == YearEnum.Freshman)
                {
                    string classes = "";
                    foreach (Course c in s.getSemesterBox().Items)
                    {
                        if (c.Description == "")
                        {
                            c.Description = "NoDesc";
                        }
                        if (c.PreReq == "")
                        {
                            c.PreReq = "NoPre";
                        }
                        classes += c.Department + '|' + c.CourseNum + '|' + c.Description + '|' + c.Hours + '|' + c.PreReq + "\n";
                    }
                    classes = classes.TrimEnd('\r', '\n');
                    Spring1.Write(classes);
                    Spring1.Close();
                }
                else if (s.ID == SemesterEnum.Fall && s.year == YearEnum.Sophomore)
                {
                    string classes = "";
                    foreach (Course c in s.getSemesterBox().Items)
                    {
                        if (c.Description == "")
                        {
                            c.Description = "NoDesc";
                        }
                        if (c.PreReq == "")
                        {
                            c.PreReq = "NoPre";
                        }
                        classes += c.Department + '|' + c.CourseNum + '|' + c.Description + '|' + c.Hours + '|' + c.PreReq + "\n";
                    }
                    classes = classes.TrimEnd('\r', '\n');
                    Fall2.Write(classes);
                    Fall2.Close();

                }
                else if (s.ID == SemesterEnum.Spring && s.year == YearEnum.Sophomore)
                {
                    string classes = "";
                    foreach (Course c in s.getSemesterBox().Items)
                    {
                        if (c.Description == "")
                        {
                            c.Description = "NoDesc";
                        }
                        if (c.PreReq == "")
                        {
                            c.PreReq = "NoPre";
                        }
                        classes += c.Department + '|' + c.CourseNum + '|' + c.Description + '|' + c.Hours + '|' + c.PreReq + "\n";
                    }
                    classes = classes.TrimEnd('\r', '\n');
                    Spring2.Write(classes);
                    Spring2.Close();
                }
                else if (s.ID == SemesterEnum.Fall && s.year == YearEnum.Junior)
                {
                    string classes = "";
                    foreach (Course c in s.getSemesterBox().Items)
                    {
                        if (c.Description == "")
                        {
                            c.Description = "NoDesc";
                        }
                        if (c.PreReq == "")
                        {
                            c.PreReq = "NoPre";
                        }
                        classes += c.Department + '|' + c.CourseNum + '|' + c.Description + '|' + c.Hours + '|' + c.PreReq + "\n";
                    }
                    classes = classes.TrimEnd('\r', '\n');
                    Fall3.Write(classes);
                    Fall3.Close();
                }
                else if (s.ID == SemesterEnum.Spring && s.year == YearEnum.Junior)
                {
                    string classes = "";
                    foreach (Course c in s.getSemesterBox().Items)
                    {
                        if (c.Description == "")
                        {
                            c.Description = "NoDesc";
                        }
                        if (c.PreReq == "")
                        {
                            c.PreReq = "NoPre";
                        }
                        classes += c.Department + '|' + c.CourseNum + '|' + c.Description + '|' + c.Hours + '|' + c.PreReq + "\n";
                    }
                    classes = classes.TrimEnd('\r', '\n');
                    Spring3.Write(classes);
                    Spring3.Close();
                }
                else if (s.ID == SemesterEnum.Fall && s.year == YearEnum.Senior)
                {
                    string classes = "";
                    foreach (Course c in s.getSemesterBox().Items)
                    {
                        if (c.Description == "")
                        {
                            c.Description = "NoDesc";
                        }
                        if (c.PreReq == "")
                        {
                            c.PreReq = "NoPre";
                        }
                        classes += c.Department + '|' + c.CourseNum + '|' + c.Description + '|' + c.Hours + '|' + c.PreReq + "\n";
                    }
                    classes = classes.TrimEnd('\r', '\n');
                    Fall4.Write(classes);
                    Fall4.Close();
                }
                else if (s.ID == SemesterEnum.Spring && s.year == YearEnum.Senior)
                {
                    string classes = "";
                    foreach (Course c in s.getSemesterBox().Items)
                    {
                        if (c.Description == "")
                        {
                            c.Description = "NoDesc";
                        }
                        if (c.PreReq == "")
                        {
                            c.PreReq = "NoPre";
                        }
                        classes += c.Department + '|' + c.CourseNum + '|' + c.Description + '|' + c.Hours + '|' + c.PreReq + "\n";
                    }
                    classes = classes.TrimEnd('\r', '\n');
                    Spring4.Write(classes);
                    Spring4.Close();
                }
            }
        }

        public Schedule readFromFile(Schedule schedule)
        {
            string line;
            if (File.Exists("Fall1.txt"))
            {
                System.IO.StreamReader Fall1R = new System.IO.StreamReader("Fall1.txt");
                while ((line = Fall1R.ReadLine()) != null || (line = Fall1R.ReadLine()) == "")
                {
                    List<string> tokens = line.Split('|').ToList();
                    if (tokens[2] == "NoDesc")
                        tokens[2] = "";
                    if (tokens[4] == "NoPre")
                        tokens[4] = "";
                    Course c = new Course(tokens[0], Convert.ToInt32(tokens[1]), tokens[2], Convert.ToInt32(tokens[3]), tokens[4]);
                    List<Semester> semesters = schedule.getSemesters();
                    Semester semester = semesters.SingleOrDefault(s => s.ID == SemesterEnum.Fall && s.year == YearEnum.Freshman);
                    semester.semesterBox.Items.Add(c);
                }
                Fall1R.Close();
            }
            if (File.Exists("Spring1.txt"))
            {
                System.IO.StreamReader Spring1R = new System.IO.StreamReader("Spring1.txt");
                while ((line = Spring1R.ReadLine()) != null)
                {
                    List<string> tokens = line.Split('|').ToList();
                    if (tokens[2] == "NoDesc")
                        tokens[2] = "";
                    if (tokens[4] == "NoPre")
                        tokens[4] = "";
                    Course c = new Course(tokens[0], Convert.ToInt32(tokens[1]), tokens[2], Convert.ToInt32(tokens[3]), tokens[4]);
                    List<Semester> semesters = schedule.getSemesters();
                    Semester semester = semesters.SingleOrDefault(s => s.ID == SemesterEnum.Spring && s.year == YearEnum.Freshman);
                    semester.semesterBox.Items.Add(c);
                }
                Spring1R.Close();
            }
            if (File.Exists("Summer1.txt"))
            {
                System.IO.StreamReader Summer1R = new System.IO.StreamReader("Summer1.txt");
                while ((line = Summer1R.ReadLine()) != null)
                {
                    List<string> tokens = line.Split('|').ToList();
                    if (tokens[2] == "NoDesc")
                        tokens[2] = "";
                    if (tokens[4] == "NoPre")
                        tokens[4] = "";
                    Course c = new Course(tokens[0], Convert.ToInt32(tokens[1]), tokens[2], Convert.ToInt32(tokens[3]), tokens[4]);
                    List<Semester> semesters = schedule.getSemesters();
                    Semester semester = semesters.SingleOrDefault(s => s.ID == SemesterEnum.Summer1 && s.year == YearEnum.Freshman);
                    semester.semesterBox.Items.Add(c);
                }
                Summer1R.Close();
            }
            if (File.Exists("Fall2.txt"))
            {
                System.IO.StreamReader Fall2R = new System.IO.StreamReader("Fall2.txt");
                while ((line = Fall2R.ReadLine()) != null)
                {
                    List<string> tokens = line.Split('|').ToList();
                    if (tokens[2] == "NoDesc")
                        tokens[2] = "";
                    if (tokens[4] == "NoPre")
                        tokens[4] = "";
                    Course c = new Course(tokens[0], Convert.ToInt32(tokens[1]), tokens[2], Convert.ToInt32(tokens[3]), tokens[4]);
                    List<Semester> semesters = schedule.getSemesters();
                    Semester semester = semesters.SingleOrDefault(s => s.ID == SemesterEnum.Fall && s.year == YearEnum.Sophomore);
                    semester.semesterBox.Items.Add(c);
                }
            }
            if (File.Exists("Spring2.txt"))
            {
                System.IO.StreamReader Spring2R = new System.IO.StreamReader("Spring2.txt");
                while ((line = Spring2R.ReadLine()) != null)
                {
                    List<string> tokens = line.Split('|').ToList();
                    if (tokens[2] == "NoDesc")
                        tokens[2] = "";
                    if (tokens[4] == "NoPre")
                        tokens[4] = "";
                    Course c = new Course(tokens[0], Convert.ToInt32(tokens[1]), tokens[2], Convert.ToInt32(tokens[3]), tokens[4]);
                    List<Semester> semesters = schedule.getSemesters();
                    Semester semester = semesters.SingleOrDefault(s => s.ID == SemesterEnum.Spring && s.year == YearEnum.Sophomore);
                    semester.semesterBox.Items.Add(c);
                }
                Spring2R.Close();
            }
            if (File.Exists("Summer2.txt"))
            {
                System.IO.StreamReader Summer2R = new System.IO.StreamReader("Summer2.txt");
                while ((line = Summer2R.ReadLine()) != null)
                {
                    List<string> tokens = line.Split('|').ToList();
                    if (tokens[2] == "NoDesc")
                        tokens[2] = "";
                    if (tokens[4] == "NoPre")
                        tokens[4] = "";
                    Course c = new Course(tokens[0], Convert.ToInt32(tokens[1]), tokens[2], Convert.ToInt32(tokens[3]), tokens[4]);
                    List<Semester> semesters = schedule.getSemesters();
                    Semester semester = semesters.SingleOrDefault(s => s.ID == SemesterEnum.Summer1 && s.year == YearEnum.Sophomore);
                    semester.semesterBox.Items.Add(c);
                }
                Summer2R.Close();
            }
            if (File.Exists("Fall3.txt"))
            {
            System.IO.StreamReader Fall3R = new System.IO.StreamReader("Fall3.txt");
            while ((line = Fall3R.ReadLine()) != null)
            {
                List<string> tokens = line.Split('|').ToList();
                if (tokens[2] == "NoDesc")
                    tokens[2] = "";
                if (tokens[4] == "NoPre")
                    tokens[4] = "";
                Course c = new Course(tokens[0], Convert.ToInt32(tokens[1]), tokens[2], Convert.ToInt32(tokens[3]), tokens[4]);
                List<Semester> semesters = schedule.getSemesters();
                Semester semester = semesters.SingleOrDefault(s => s.ID == SemesterEnum.Fall && s.year == YearEnum.Junior);
                semester.semesterBox.Items.Add(c);
            }
            Fall3R.Close();
            }
            if (File.Exists("Spring3.txt"))
            {
                System.IO.StreamReader Spring3R = new System.IO.StreamReader("Spring3.txt");
                while ((line = Spring3R.ReadLine()) != null)
                {
                    List<string> tokens = line.Split('|').ToList();
                    if (tokens[2] == "NoDesc")
                        tokens[2] = "";
                    if (tokens[4] == "NoPre")
                        tokens[4] = "";
                    Course c = new Course(tokens[0], Convert.ToInt32(tokens[1]), tokens[2], Convert.ToInt32(tokens[3]), tokens[4]);
                    List<Semester> semesters = schedule.getSemesters();
                    Semester semester = semesters.SingleOrDefault(s => s.ID == SemesterEnum.Spring && s.year == YearEnum.Junior);
                    semester.semesterBox.Items.Add(c);
                }
                Spring3R.Close();
            }
            if (File.Exists("Summer3.txt"))
            {
                System.IO.StreamReader Summer3R = new System.IO.StreamReader("Summer3.txt");
                while ((line = Summer3R.ReadLine()) != null)
                {
                    List<string> tokens = line.Split('|').ToList();
                    if (tokens[2] == "NoDesc")
                        tokens[2] = "";
                    if (tokens[4] == "NoPre")
                        tokens[4] = "";
                    Course c = new Course(tokens[0], Convert.ToInt32(tokens[1]), tokens[2], Convert.ToInt32(tokens[3]), tokens[4]);
                    List<Semester> semesters = schedule.getSemesters();
                    Semester semester = semesters.SingleOrDefault(s => s.ID == SemesterEnum.Summer1 && s.year == YearEnum.Junior);
                    semester.semesterBox.Items.Add(c);
                }
                Summer3R.Close();
            }
            if (File.Exists("Fall4.txt"))
            {
                System.IO.StreamReader Fall4R = new System.IO.StreamReader("Fall4.txt");
                while ((line = Fall4R.ReadLine()) != null)
                {
                    List<string> tokens = line.Split('|').ToList();
                    if (tokens[2] == "NoDesc")
                        tokens[2] = "";
                    if (tokens[4] == "NoPre")
                        tokens[4] = "";
                    Course c = new Course(tokens[0], Convert.ToInt32(tokens[1]), tokens[2], Convert.ToInt32(tokens[3]), tokens[4]);
                    List<Semester> semesters = schedule.getSemesters();
                    Semester semester = semesters.SingleOrDefault(s => s.ID == SemesterEnum.Fall && s.year == YearEnum.Senior);
                    semester.semesterBox.Items.Add(c);
                }
                Fall4R.Close();
            }
            if (File.Exists("Spring4.txt"))
            {
                System.IO.StreamReader Spring4R = new System.IO.StreamReader("Spring4.txt");
                while ((line = Spring4R.ReadLine()) != null)
                {
                    List<string> tokens = line.Split('|').ToList();
                    if (tokens[2] == "NoDesc")
                        tokens[2] = "";
                    if (tokens[4] == "NoPre")
                        tokens[4] = "";
                    Course c = new Course(tokens[0], Convert.ToInt32(tokens[1]), tokens[2], Convert.ToInt32(tokens[3]), tokens[4]);
                    List<Semester> semesters = schedule.getSemesters();
                    Semester semester = semesters.SingleOrDefault(s => s.ID == SemesterEnum.Spring && s.year == YearEnum.Senior);
                    semester.semesterBox.Items.Add(c);
                }
                Spring4R.Close();
            }
            if (File.Exists("Summer4.txt"))
            {
                System.IO.StreamReader Summer4R = new System.IO.StreamReader("Summer4.txt");
                while ((line = Summer4R.ReadLine()) != null)
                {
                    List<string> tokens = line.Split('|').ToList();
                    if (tokens[2] == "NoDesc")
                        tokens[2] = "";
                    if (tokens[4] == "NoPre")
                        tokens[4] = "";
                    Course c = new Course(tokens[0], Convert.ToInt32(tokens[1]), tokens[2], Convert.ToInt32(tokens[3]), tokens[4]);
                    List<Semester> semesters = schedule.getSemesters();
                    Semester semester = semesters.SingleOrDefault(s => s.ID == SemesterEnum.Summer1 && s.year == YearEnum.Senior);
                    semester.semesterBox.Items.Add(c);
                }
                Summer4R.Close();
            }
            return schedule;
        }
    }
}
