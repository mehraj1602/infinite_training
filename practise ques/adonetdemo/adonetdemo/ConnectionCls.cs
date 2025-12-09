using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetdemo
{
    internal class ConnectionCls
    {
        SqlConnection con;
        public ConnectionCls()
        {
            con = new SqlConnection("uid=sa;pwd=Infinite@2025;database=infinitedb;server=ICS-LT-BJ43YS3");
        }
        public void ShowEmployee()
        {
            // display all records from employee table

            con.Open(); // creates a new connection

            // writes a command

            SqlCommand cmd = new SqlCommand("select * from employee", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) // run the loop only if record is found 
            {
                // it reads row by row
                Console.WriteLine($"{dr[0]}   {dr[1]}   {dr[2]}    {dr[3]}    {dr[4]}");
            }

            con.Close();

        }

        public void AddEmployee()
        {
            // Add records to employee table
            con.Open(); // creates a new connection

            // writes a command
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Salary:");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Joining Date (yyyy-mm-dd):");
            string doj = Console.ReadLine();

            Console.WriteLine("Enter Department Id: (10/20/30/40/50)");
            int deptid = Convert.ToInt32(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("insert into employee values (@name,@salary,@doj,@deptid)", con);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@salary", salary);
            cmd.Parameters.AddWithValue("@doj", doj);
            cmd.Parameters.AddWithValue("@deptid", deptid);

            int rowaffected = cmd.ExecuteNonQuery();

            Console.WriteLine("Total Records Inserted is " + rowaffected);

            con.Close();

        }

        public void DeleteEmployee()
        {
            // delete from  employee table by id
            con.Open(); // creates a new connection


            Console.WriteLine("Enter Employee ID to Delete:");
            int empid = Convert.ToInt32(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("DELETE FROM employee WHERE empid = @id", con);

            cmd.Parameters.AddWithValue("@id", empid);

            int rowaffected = cmd.ExecuteNonQuery();

            Console.WriteLine("Total Records Deleted:" + rowaffected);

            con.Close();
        }

        public void UpdateEmployee()
        {
            // update to employee table

            //update salary by id
            con.Open(); // creates a new connection

            Console.WriteLine("Enter Employee ID to Update:");
            int empid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter New Salary:");
            int salary = Convert.ToInt32(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("UPDATE employee SET salary=@salary WHERE empid=@id", con);

            cmd.Parameters.AddWithValue("@id", empid);
            cmd.Parameters.AddWithValue("@salary", salary);

            int rowaffected = cmd.ExecuteNonQuery();

            Console.WriteLine("Total Records Updated:" + rowaffected);
        }

        public void Showprocedure()
        {
            // display all records from employee table


            con.Open(); // creates a new connection

            // writes a command

            SqlCommand cmd = new SqlCommand("sp_getemp", con);

            SqlParameter p1 = new SqlParameter("@d", 10); // create a parameter
            SqlParameter p2 = new SqlParameter("@sal", 46000);
            cmd.Parameters.Add(p1);// attaching paramater to procedure
            cmd.Parameters.Add(p2);


            cmd.CommandType = CommandType.StoredProcedure;// represents type of command u are trying to execute
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) // run the loop only if record is found 
            {
                // it reads row by row

                Console.WriteLine($"{dr[0]}   {dr[1]}   {dr[2]}    {dr[3]}    {dr[4]}");

            }



            con.Close();

        }

        public void EmpTransaction()
        {

            SqlTransaction tr = null;

            try
            {
                // Add records to employee table

                con.Open(); // creates a new connection

                tr = con.BeginTransaction();// starts the transaction
                                            // writes a command

                SqlCommand cmd1 = new SqlCommand("insert into one values(2,'vijay')", con);
                SqlCommand cmd2 = new SqlCommand("insert into two values(1,'vijay')", con);

                cmd1.Transaction = tr;// now cmd1 will be part of transaction
                cmd2.Transaction = tr;// now cmd2 will be part of transaction
                int rowaffected1 = cmd1.ExecuteNonQuery();
                int rowaffected2 = cmd2.ExecuteNonQuery();
                Console.WriteLine("Total Records Inserted is " + rowaffected1);
                Console.WriteLine("Total Records Inserted is " + rowaffected2);
                tr.Commit();
                con.Close();

            }
            catch (Exception ex)
            {
                tr.Rollback();
                Console.WriteLine("Could not complete.. try again...");
            }
        }
    }
}
