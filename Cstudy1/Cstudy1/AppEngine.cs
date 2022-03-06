using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Cstudy1
{
   

    class AppEngine
    {
        
        public static SqlCommand cmd1;
        public static SqlCommand cmd2;
        public static SqlCommand cmd3;
        public static SqlCommand cmd4;
        public static SqlCommand cmd5;
        public static SqlCommand cmd6;
        public static SqlCommand cmd7;
        public static SqlCommand cmd8;
        public static SqlCommand cmd9;
        public static SqlCommand cmd10;
        public static SqlCommand cmd11;
        public static SqlDataReader dr;
        //public static SqlDataReader dr1;
        public static SqlConnection con;
        //give db connection to these functions

        static SqlConnection getConnection()
        {
            con = new SqlConnection("Data Source=DESKTOP-A9R1Q7C;Initial Catalog=casestudy;User id=DESKTOP-A9R1Q7C\\VENKAT KANNEGANTI;Password=2701;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();
            return con;
        }


        public void showStudentScreen()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("show the details of the student");
                Console.WriteLine("enter student sid");
                int sid = Convert.ToInt32(Console.ReadLine());
                cmd1 = new SqlCommand("select * from Student where stdid = @stdid", con);
                cmd1.Connection = con;
                cmd1.Parameters.AddWithValue("@stdid", sid);

                dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student Details : ");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Student Id : " + " " + dr[0]);
                    Console.WriteLine("Student Name :" + " " + dr[1]);
                    Console.WriteLine("Student DOB :" + " " + dr[2]);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("error occured", se);
            }
        }

        public void studentregistration()
        {
            int n;
            Console.WriteLine("enter no of student details u want to insert");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                con = getConnection();
                Console.WriteLine("Enter student details");
                Console.WriteLine("Enter id");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter DOB:");
                string DateOfBirth = Console.ReadLine();
                cmd2 = new SqlCommand("insert into Student values (@stdid,@stdname,@sdob)", con);
                cmd2.Parameters.AddWithValue("@stdid", Id);
                cmd2.Parameters.AddWithValue("@stdname", Name);
                cmd2.Parameters.AddWithValue("@sdob", DateOfBirth);
                int res1 = cmd2.ExecuteNonQuery();
                if (res1 > 0)
                {
                    Console.WriteLine("Student details inserted Sucessfully");
                }
                else
                    Console.WriteLine("please enter valid student details");
            }
        }

        public void Available_Courses()
        {
            //Admin module reveals courses in there Institute
            con = getConnection();
            cmd3 = new SqlCommand("Select * from Course", con);
            int res2 = cmd3.ExecuteNonQuery();
            Console.WriteLine("Courses Available In the Institution are................!");
            dr = cmd3.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Course Details : ");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Course Id : " + " " + dr[0]);
                Console.WriteLine("Course Name :" + " " + dr[1]);
                Console.WriteLine("Course Duration :" + " " + dr[2]);
                Console.WriteLine("Course Fees :" + " " + dr[3]);
            }
        }

        public void Show_all_registered_Students()
        {
            //whenever we need to retrieve total no.of students in the institute and there details from admin level
            con = getConnection();
            cmd4 = new SqlCommand("Select * from Student", con);
            int res3 = cmd4.ExecuteNonQuery();
            dr = cmd4.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Student Details : ");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Student Id : " + " " + dr[0]);
                Console.WriteLine("Student Name :" + " " + dr[1]);
                Console.WriteLine("Student DOB :" + " " + dr[2]);
                Console.WriteLine();
            }
        }

        public void introducingnewCourse()
        {
            con = getConnection();
            
           
            

            Console.WriteLine("Enter Course Id");
            int CID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Course Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Course duration");
            string dur = Console.ReadLine();
            Console.WriteLine("Enter Course fee");
            int fees = Convert.ToInt32(Console.ReadLine());
           
            cmd5 = new SqlCommand("insert into Course values(@cid,@Namee,@dur,@cfee)", con);
            cmd5.Parameters.AddWithValue("@cid", CID);
            cmd5.Parameters.AddWithValue("@Namee", name);
            cmd5.Parameters.AddWithValue("@dur", dur);
            cmd5.Parameters.AddWithValue("@cfee", fees);
            
            
            int res4 = cmd5.ExecuteNonQuery();
            if (res4 > 0)
            {
                Console.WriteLine("Course added Sucessfully");
            }
            else
                Console.WriteLine("Please enter valid details");
        }


        public void UpdateStudentdetails()
        {
            con = getConnection();
            //creating sql cmnd
            
            Console.WriteLine("enter student id");
            int SId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student Name you need to update: ");
            string stName = Console.ReadLine();
            Console.WriteLine("Enter student Dob you need to change: ");
            string dob = Console.ReadLine();

            cmd6 = new SqlCommand("update student set stdname  = @stdname,sdob = @sdob where stdid = @stdid", con);
            
            cmd6.Parameters.AddWithValue("@stdname", stName);
            cmd6.Parameters.AddWithValue("@sdob", dob);
            cmd6.Parameters.AddWithValue("@stdid", SId);

            int res5 = cmd6.ExecuteNonQuery();
            if (res5 > 0)
            {
                Console.WriteLine("student data updated Sucessfully");
            }
            else
            {
                Console.WriteLine("please enter valid data");
            }
        }

        public void updatecourseDetails()
        {
            con = getConnection();
            //creating sql cmnd
            Console.WriteLine("enter course id");
            int CId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter Course duration u need to update");
            string Cdur = Console.ReadLine();
            Console.WriteLine("Enter Course fee u need to update");
            int Cfee = Convert.ToInt32(Console.ReadLine());

            cmd7 = new SqlCommand("update Course set dur  = @dur, cfee = @cfee where  cid=@Cid", con);


            cmd7.Parameters.AddWithValue("@dur", Cdur);
            cmd7.Parameters.AddWithValue("@cfee", Cfee);
            cmd7.Parameters.AddWithValue("@Cid", CId);

            int res6 = cmd7.ExecuteNonQuery();
            if (res6 > 0)
            {
                Console.WriteLine("course updated Sucessfully");
            }
            else
            {
                Console.WriteLine("please enter valid data");
            }
        }

        public void DeleteStudentdetails()
        {
            con = getConnection();
            //creating sql cmnd
            Console.WriteLine("enter student id");
            int SId = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter student Name: ");
            //string stName = Console.ReadLine();
            //Console.WriteLine("Enter student Dob: ");
            //string dob = Console.ReadLine();

            cmd8 = new SqlCommand("delete student  where stdid = @stdid", con);
            cmd8.Parameters.AddWithValue("@stdid", SId);
            //cmd3.Parameters.AddWithValue("@stdname", stName);
            //cmd3.Parameters.AddWithValue("@sdob", dob);

            int res7 = cmd8.ExecuteNonQuery();
            if (res7 > 0)
            {
                Console.WriteLine("Row Deleted Sucessfully");
            }
            else
            {
                Console.WriteLine("please enter valid data");
            }
        }

        public void DeleteCoursedetails()
        {
            try
            {


                con = getConnection();
                //creating sql cmnd
                Console.WriteLine("enter course id");
                int CId = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Enter student Name: ");
                //string stName = Console.ReadLine();
                //Console.WriteLine("Enter student Dob: ");
                //string dob = Console.ReadLine();

                cmd9 = new SqlCommand("delete Course  where cid = @cid", con);
                cmd9.Parameters.AddWithValue("@cid", CId);
                //cmd3.Parameters.AddWithValue("@stdname", stName);
                //cmd3.Parameters.AddWithValue("@sdob", dob);

                int res8 = cmd9.ExecuteNonQuery();
                if (res8 > 0)
                {
                    Console.WriteLine("Row Deleted Sucessfully");
                }
                else
                {
                    Console.WriteLine("please enter valid data");
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("u cannot delete particular course because student is enrooled to that course", se);
            }
        }

        public void Retrieve_Particular_Course()
        {
            try
            {
                //whenever we are trying to retrieve particular student details
                con = getConnection();
                int CId;
                Console.WriteLine("Enter Course Id");
                CId = Convert.ToInt32(Console.ReadLine());
                cmd10 = new SqlCommand("select * from Course where cid=@cid", con);
                cmd10.Parameters.AddWithValue("@cid", CId);
                dr = cmd10.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Particular Course Details : ");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Course Id : " + " " + dr[0]);
                    Console.WriteLine("Course Name :" + " " + dr[1]);
                    Console.WriteLine("Course Duration :" + " " + dr[2]);
                    Console.WriteLine("Course Fees :" + " " + dr[3]);
                    Console.WriteLine();
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("Course Doesn't Exist...........!", se);
            }


        }
        public void enrolling_Course()
        {
            con = getConnection();
            int SId, CID;
            DateTime Enroll_Date;
            Console.WriteLine("Enter Student Id");
            SId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Course Id");
            CID = Convert.ToInt32(Console.ReadLine());
            Enroll_Date = DateTime.UtcNow;
            cmd11 = new SqlCommand("insert into Enroll values(@Cid,@stdid,@enrolment)", con);
            cmd11.Parameters.AddWithValue("@Cid", CID);
            cmd11.Parameters.AddWithValue("@stdid", SId);
            cmd11.Parameters.AddWithValue("@enrolment", Enroll_Date);
            int res9 = cmd11.ExecuteNonQuery();
            if (res9 > 0)
            {
                Console.WriteLine("Student enrolled to the Course Sucessfully");
            }
            else
                Console.WriteLine("Please enter valid details");
        }

    }


}



