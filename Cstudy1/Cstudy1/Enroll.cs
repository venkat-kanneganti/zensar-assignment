using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstudy1
{
    class Enroll
    {
        private Student student;
        private Course course;
        private DateTime enrollmentDate;

        //public List<Course> CourseList = new List<Course>();
        //public List<Student> StudentList = new List<Student>();
        //public List<Enroll> EnrollList = new List<Enroll>();

        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }
    }
}
