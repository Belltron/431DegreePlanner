using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreePlanner
{
    enum SemesterEnum
    {
        Fall = 0,Spring,Summer1,Summer2
    }
    
    class Semester
    {
        private List<Course> Courses;
        private SemesterEnum semesterEnum;
        public SemesterEnum getSemesterEnum()
        {
            return this.semesterEnum;
        }
    }
}
