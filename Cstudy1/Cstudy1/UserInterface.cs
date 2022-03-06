using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstudy1
{
    abstract class UserInterface
    {
            public abstract void showFirstScreen();
            public abstract void showStudentScreen();
            public abstract void showAdminScreen();
            public abstract void showAllStudentsScreen();
            public abstract void showStudentRegistrationScreen();
            public abstract void introduceNewCourseScreen();
            public abstract void showAllCoursesScreen();
    }
        class Institute_Details : UserInterface
        {
            string r;
            public override void showFirstScreen()
            {
            do
            {
                Console.WriteLine("Welcome to SMS(Student Management System)");
                Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin\n");
                Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        showStudentScreen();
                        break;
                    case 2:
                        showAdminScreen();
                        break;
                   
                }
                   Console.WriteLine("Do you want to continue in Main screen YES/NO:");
                    r = Console.ReadLine();
            } 
            while ((r == "YES") || (r == "yes"));
        }
        public override void showStudentScreen()
        {
            do
            {
                AppEngine ae = new AppEngine();
                Console.WriteLine("Select: \n1.Check your Details(Existing User)\n2.Registration(New User)\n3.Search Available Courses\n4.Enroll to Course in List");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        // Checks whether new registrartion or already existing user
                        ae.showStudentScreen();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 2://New registration
                        this.showStudentRegistrationScreen();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    //case 3:
                    //    //updating Student details
                    //    ae.UpdateStudentdetails();
                    //    Console.WriteLine("Action Completed you may Exit....!");
                    //    break;
                    case 3:
                        //Showcase all available courses
                        Console.WriteLine("--------------------List of Courses------------------------");
                        ae.Available_Courses();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 4:
                        //Student enrolling to particular course
                        ae.enrolling_Course();
                        Console.WriteLine("You have successfully enrolled you may Exit the Screen now");
                        break;
                    default:
                        Console.WriteLine("Enter valid Option....!");
                        break;
                }
                    Console.WriteLine("Do you want to continue in student screen YES/NO:");
                    r = Console.ReadLine();

            }
            while ((r == "YES") || (r == "yes"));
        }
        public override void showAdminScreen()
        {
          do
          {
              AppEngine aE = new AppEngine();
              Console.WriteLine("Select: \n1.Introduce New Course\n2.Courses Available\n3.Update Course Details\n4.Retrieve Particular Course in List\n5.Deleting Existing Student\n6.Delete Course\n7.Update Student Details\n8.all student details");
              int op = Convert.ToInt32(Console.ReadLine());
              switch (op)
              {
                case 1:
                    //If any new course want to add for Organization
                    this.introduceNewCourseScreen();
                    Console.WriteLine("Action Completed you may Exit....!");
                    break;
                case 2:
                    //list of existing courses
                    Console.WriteLine("-------------All Available Courses in Institute-------------------");
                    this.showAllCoursesScreen();
                    Console.WriteLine("Action Completed you may Exit....!");
                    break;
                case 3:
                    //updates in Course structure
                    aE.updatecourseDetails();
                    Console.WriteLine("Action Completed you may Exit....!");
                    break;
                case 4:
                    //getting particular course details
                    aE.Retrieve_Particular_Course();
                    Console.WriteLine("Action Completed you may Exit....!");
                    break;
                case 5:
                    //deletes particular student
                    aE.DeleteStudentdetails();
                    Console.WriteLine("Action Completed you may Exit....!");
                    break;
                case 6:
                    //deletes existing course only that are not enrolled by any students
                    aE.DeleteCoursedetails();
                    Console.WriteLine("Action Completed you may Exit....!");
                    break;
                case 7:
                    //modify existing student details
                    aE.UpdateStudentdetails();
                    Console.WriteLine("Action Completed you may Exit....!");
                    break;
                case 8:
                        //to get all student details
                        this.showAllStudentsScreen();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;

                    default:
                    Console.WriteLine("Enter valid Option....!");
                    break;

              }
                Console.WriteLine("Do you want to continue in Admin screen YES/NO:");
                r = Console.ReadLine();
          }
                 while ((r == "YES") || (r == "yes"));
        }
        public override void showAllStudentsScreen()
            {
                AppEngine Ae = new AppEngine();
                Ae.Show_all_registered_Students();
            }
            public override void showStudentRegistrationScreen()
            {
                AppEngine Ae = new AppEngine();
                Ae.studentregistration();

            }
            public override void introduceNewCourseScreen()
            {
                AppEngine Ae = new AppEngine();
                Ae.introducingnewCourse();
            }
            public override void showAllCoursesScreen()
            {
                AppEngine ae = new AppEngine();
                ae.Available_Courses();
            }

        }
}
