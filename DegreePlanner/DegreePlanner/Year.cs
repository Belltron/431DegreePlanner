using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreePlanner
{

    enum YearEnum
    {
        Freshman = 0,Sophomore,Junior,Senior,SuperSenior,SuperDuperSenior
    }

    class Year
    {
        private List<Semester> Semesters;
        private YearEnum yearEnum;
        public YearEnum getYearEnum()
        {
            return this.yearEnum;
        }
        public void SortSemesters()
        {
            Semesters = Semesters.OrderBy(semester => semester.getSemesterEnum()).ToList();
        }
    }
}
