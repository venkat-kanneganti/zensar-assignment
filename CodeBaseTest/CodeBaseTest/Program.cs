using System;
using System.Data.SqlClient;

namespace CodeBaseTest
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
            InsertData();
        }
        static SqlConnection getConnection()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-C111ENL;Initial Catalog=EmployeeManagement;User id=DESKTOP-C111ENL\\VENKAT.K;Password=2701;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();
            return con;
        }
        static void InsertData()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter Employee Details : ");
                string ename, etype;
                float esal;
                Console.WriteLine("Enter Employee Name : ");
                ename = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary : ");
                esal = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Type 'C' Or 'P' :");
                etype = Console.ReadLine();
                cmd = new SqlCommand("execute dbo.addnewemployee @ename, @esal, @etype");
                cmd.Parameters.AddWithValue("@ename", ename);
                cmd.Parameters.AddWithValue("@esal", esal);
                cmd.Parameters.AddWithValue("@etype", etype);
                cmd.Connection = con;
                int no_of_rows = cmd.ExecuteNonQuery();
                if (no_of_rows > 0)
                {
                    Console.WriteLine("Number of Rows affected are : {0} ", no_of_rows);
                }
                else
                {
                    Console.WriteLine("NO Rows Affected");
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }


    }

}

