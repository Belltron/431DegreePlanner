using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegreePlanner
{
    class Semester
    {
        public ListBox semesterBox;
        private SemesterEnum ID;
        private YearEnum year;

        public Semester()
        {
            semesterBox = new ListBox();
            semesterBox.AllowDrop = true;
            ID = 0;
        }

        public Semester(SemesterEnum i, YearEnum y)
        {
            semesterBox = new ListBox();
            semesterBox.AllowDrop = true;
            ID = i;
            year = y;
        }

        public ListBox getSemesterBox()
        {
            return semesterBox;
        }

        public SemesterEnum getID()
        {
            return ID;
        }

        public YearEnum getYear()
        {
            return year;
        }
    }
}
