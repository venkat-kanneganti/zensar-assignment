using Cstudy1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstudy1
{
    class App
    {
        public static void Scenario1()
        {
            //creating student class object
            Info info = new Info();
            Student student = new Student(101, "pavan", "1-2-1998");
            Student student1 = new Student(102, "kittu", "1-2-3456");
            Student student2 = new Student(103, "munna", "1-23-4566");
            info.display(student);
            info.display(student1);
            info.display(student2);
        }
        public static void Scenario2()
        {
            //taking an array call the student class and display in display method
            Info info = new Info();
            Student[] std = new Student[3];
            std[0] = new Student(101, "venkat", "1-2-1998");
            std[1] = new Student(102, "srikanth", "1-2-1997");
            std[2] = new Student(103, "harsha", "1-23-1996");
            for (int i = 0; i < std.Length; i++)
            {
                info.display(std[i]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static void Scenario3()
        {
            //creating object and array
            Student[] std = new Student[2];

            for (int i = 0; i < std.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the Student ID:");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Student Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter the Student DateOfBirth:");
                string DateOfBirth = Console.ReadLine();
                //assinging student object array calling inn info class
                Student s1 = new Student(Id, Name, DateOfBirth);
                std[i] = s1;
            }
            foreach (var r in std)
            {
                Console.WriteLine(r.Id);
                Console.WriteLine(r.Name);
                Console.WriteLine(r.DateOfBirth);
            }
        }
        public static void CScenario1()
        {
            Console.WriteLine("--------------Course:Scenario1---------------");
            Info info = new Info();
            Course crse = new Course(1, "JAVASCRIPT", "1 Month", 5000);
            Course crse1 = new Course(2, "HTML", "1 Month", 7000);
            Course crse2 = new Course(3, "Devops", "2 Months", 10000);
            info.display(crse);
            Console.WriteLine();
            info.display(crse1);
            Console.WriteLine();
            info.display(crse2);
        }
        public static void CScenario2()
        {
            Console.WriteLine("------------Course:Scenario2-----------------");
            Info info = new Info();
            Course[] cse = new Course[3];
            cse[0] = new Course(4, "CLanguage", "2 Months", 8000);
            cse[1] = new Course(5, "DBMS", "1 Months", 6000);
            cse[2] = new Course(6, "RLanguage", "2 Months", 12000);
            for (int i = 0; i < cse.Length; i++)
            {
                info.display(cse[i]);
                Console.WriteLine();
            }
        }
        public static void CScenario3()
        {
            Console.WriteLine("------------Course:Scenario3-----------------");
            Course[] cse = new Course[3];
            for (int i = 0; i < cse.Length; i++)
            {
                Console.WriteLine("Enter Course ID:");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Course Duration:");
                string Duration = Console.ReadLine();
                Console.WriteLine("Enter Course Fee:");
                int fee = int.Parse(Console.ReadLine());
                Course c1 = new Course(Id, Name, Duration, fee);
                cse[i] = c1;
            }
            foreach (var r in cse)
            {
                Console.WriteLine("\nCourse ID:{0}\nCourse Name:{1}\nCourse Duration:{2}\nCourse Fee:{3}\n", r.CID, r.CName, r.Duration, r.Fees);
            }
        }

        static void Main(string[] args)
        {
            AppEngine ae = new AppEngine();
            //Scenario1();
            //Scenario2();
            //Scenario3();
            //CScenario1();
            //CScenario2();
            //CScenario3();
            Institute_Details ID = new Institute_Details();
            ID.showFirstScreen();

            //AppEngine ae = new AppEngine();
            //ae.showStudentScreen();
            //ae.studentregistration();
            //ae.Available_Courses();
            //ae.UpdateStudentdetails();
            //ae.DeleteCoursedetails();
            //ae.introducingnewCourse();
            //ae.DeleteStudentdetails();
            //ae.updatecourseDetails();
            //ae.Show_all_registered_Students();

            
           

           
            
            Console.Read();
        }
    }
}
