using System;
using System.Data;
using System.Data.SqlClient;

namespace Test_05_ADO
{
    class Program
    {
        public static SqlConnection con;

        static SqlConnection GetConnection()
        {
            //when windows authenticated
            con = new SqlConnection("Data Source=ICS-LT-DJK96V3;Initial Catalog=Database_Submissions;" +
                "Integrated Security=True");
            con.Open();
            return con;
        }

        static void InsertData()
        {
            con = GetConnection();
            try
            {
                string empname;
                float empsal;
                char emptype;
                Console.WriteLine("Please Enter EmpName,Salary and Empotype :");
                empname = Console.ReadLine();                
                empsal = Convert.ToSingle(Console.ReadLine());
                emptype = Convert.ToChar(Console.ReadLine());
                
                SqlCommand cmd = new SqlCommand("Add_Employee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@emponame", empname);
                cmd.Parameters.AddWithValue("@emposal", empsal);
                cmd.Parameters.AddWithValue("@empotype", emptype);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Record Inserted");
                else
                    Console.WriteLine("Not Inserted..");
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }

        }

        static void DisplayDetails()
        {
            con = GetConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM code_employee", con);
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("Employee Records:");
            while (reader.Read())
            {
                int empno = reader.GetInt32(0);
                string empname = reader.GetString(1);
                decimal empsal = reader.GetDecimal(2);
                char emptype = reader.GetString(3)[0];
                Console.WriteLine($"EmpNo: {empno}, EmpName: {empname}, EmpSal: {empsal}, EmpType: {emptype}");
            }
        }

        static void Main()
        {
            InsertData();
            DisplayDetails();
            Console.Read();
        }
    }
}