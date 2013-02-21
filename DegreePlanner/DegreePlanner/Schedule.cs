using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreePlanner
{
    class Schedule
    {
        private List<Year> Years;
        public void SortYears()
        {
            Years = Years.OrderBy(year => year.getYearEnum()).ToList();
        }
        public void SortSchedual()
        {
            this.SortYears();
            foreach (var year in Years)
            {
                year.SortSemesters();
            }
        }
    }
}
