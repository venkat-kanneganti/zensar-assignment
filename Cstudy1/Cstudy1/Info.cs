using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstudy1
{
    class Info
    {


        public void display(Student s1)
        {

            Console.WriteLine("Student Details:");
            Console.WriteLine("Student ID:" + s1.Id);
            Console.WriteLine("Student Name:" + s1.Name);
            Console.WriteLine("Student DOB:" + s1.DateOfBirth);
        }

        public void display(Course c1)
        {
            Console.WriteLine("Course Details:");
            Console.WriteLine("Course ID:" + c1.CID);
            Console.WriteLine("Course Name:" + c1.CName);
            Console.WriteLine("Course Duration:" + c1.Duration);
            Console.WriteLine("Course Fee:" + c1.Fees);
        }

        public void display()
        {


            List<Course> CourseList = new List<Course>()
            {
                new Course(1,"java", "1Month", 20000),
                new Course(2,"c", "2Months", 30000),
                new Course(3,"HTML", "3months", 40000),
                new Course(4,"Java Script", "4months", 50000),
                new Course(5,"dot net", "5months", 60000),
            };
        }
    }
}
    





