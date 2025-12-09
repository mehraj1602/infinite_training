using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetAssignment
{
    internal class ConnectedArchitecture
    {
        SqlConnection con;
        public ConnectedArchitecture()
        {
            con = new SqlConnection("uid=sa;pwd=Infinite@2025;database=infinitedb;server=ICS-LT-BJ43YS3");
        }

        public void GetTransactions(DateTime d1, DateTime d2)
        {
            try
            {
                if (con == null)
                    throw new Exception("Connection object is null");
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();
                    }
                    catch
                    {
                        throw new Exception("Connection not opened");
                    }
                }

                SqlCommand cmd = new SqlCommand("sp_GetEmployeesByDate", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@d1", d1);
                cmd.Parameters.AddWithValue("@d2", d2);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + "  " + dr[1] + "  " + dr[2] + "  " + dr[3] + "  " + dr[4]);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        
        /// 2nd TASK////////////
        public void GetCommonRecords()
        {
            try
            {
                Console.WriteLine("Enter department Id:");
                int deptId = int.Parse(Console.ReadLine());

                if (con == null)
                    throw new Exception("Connection object is null");
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();
                    }
                    catch
                    {
                        throw new Exception("Connection not opened");
                    }
                }

                SqlCommand cmd = new SqlCommand("sp_getCommon", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@deptId", deptId);
                cmd.Parameters.Add(p1);

                SqlDataReader dr = cmd.ExecuteReader();
                Console.WriteLine("Common employee + department records");
                while (dr.Read())
                {
                    Console.WriteLine($"{dr["EmpId"]} \t {dr["EmpName"]}\t {dr["DeptName"]}\t {dr["Salary"]}");
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        //3RD TASK
        public void InsertRecordsusingtrans()
        {
            if (con == null)
                throw new Exception("Connection object is null");

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                }
                catch
                {
                    throw new Exception("connection could not be opened");
                }
            }
            SqlTransaction trans = con.BeginTransaction();

            Console.WriteLine("Enter Department ID:");
            int deptId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Department Name:");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter Employee Name:");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter Salary:");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Date Of Joining (yyyy-mm-dd):");
            DateTime doj = Convert.ToDateTime(Console.ReadLine());

            try
            {

                SqlCommand cmdDept = new SqlCommand("InsertDepartment", con, trans);
                cmdDept.CommandType = CommandType.StoredProcedure;
                cmdDept.Parameters.AddWithValue("@DeptID", deptId);
                cmdDept.Parameters.AddWithValue("@DeptName", deptName);
                cmdDept.ExecuteNonQuery();

                SqlCommand cmdEmp = new SqlCommand("InsertEmployee", con, trans);
                cmdEmp.CommandType = CommandType.StoredProcedure;
                cmdEmp.Parameters.AddWithValue("@EmpName", empName);
                cmdEmp.Parameters.AddWithValue("@Salary", salary);
                cmdEmp.Parameters.AddWithValue("@DateOfJoin", doj);
                cmdEmp.Parameters.AddWithValue("@DeptID", deptId);
                cmdEmp.ExecuteNonQuery();

                trans.Commit();
                Console.WriteLine("\nTransaction Successful! Records Inserted.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                // Rollback
                trans.Rollback();
                Console.WriteLine("Transaction Failed! " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        //4TH Task
        public void InsertEmployeeFetchIdentity()
        {
            if (con == null)
                throw new Exception("Connection object is null");

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                }
                catch
                {
                    throw new Exception("connection could not be opened");
                }
            }

            Console.WriteLine("Enter Employee Name:");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter Salary:");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Date of Join (yyyy-mm-dd):");
            DateTime doj = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter Dept ID:");
            int deptId = Convert.ToInt32(Console.ReadLine());

            try
            {

                string insertQuery =
                "insert into Employee (EmpName, Salary, DateOfJoin, DeptID) " +
                "values (@EmpName, @Salary, @DateOfJoin, @DeptID); " +
                "select scope_identity();";

                SqlCommand cmdInsert = new SqlCommand(insertQuery, con);
                cmdInsert.Parameters.AddWithValue("@EmpName", empName);
                cmdInsert.Parameters.AddWithValue("@Salary", salary);
                cmdInsert.Parameters.AddWithValue("@DateOfJoin", doj);
                cmdInsert.Parameters.AddWithValue("@DeptID", deptId);

                object result = cmdInsert.ExecuteScalar();
                int newId = Convert.ToInt32(result);

                Console.WriteLine($"\nNew Employee Inserted with EmpID = {newId}");

                string selectQuery = "select EmpID, EmpName, Salary, DateOfJoin, DeptID from Employee where EmpID = @ID";

                SqlCommand cmdSelect = new SqlCommand(selectQuery, con);
                cmdSelect.Parameters.AddWithValue("@ID", newId);

                SqlDataReader dr = cmdSelect.ExecuteReader();

                if (dr.Read())
                {
                    Console.WriteLine("\nRecord Found! Details:");
                    Console.WriteLine($"EmpID      : {dr["EmpID"]}");
                    Console.WriteLine($"EmpName    : {dr["EmpName"]}");
                    Console.WriteLine($"Salary     : {dr["Salary"]}");
                    Console.WriteLine($"DateOfJoin : {dr["DateOfJoin"]}");
                    Console.WriteLine($"DeptID     : {dr["DeptID"]}");
                }
                else
                {
                    Console.WriteLine("\nRecord not Found!");
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        //Task 5
        public void DisplayEmployeesDepartments()
        {
            if (con == null)
                throw new Exception("Connection object is null");

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                }
                catch
                {
                    throw new Exception("connection could not be opened");
                }
            }

            try
            {
                string query = @"
                select e.EmpID, e.EmpName, e.Salary, d.DeptName
                from Employee e
                inner join Department d ON e.DeptID = d.DeptID;

                select DeptID, DeptName from Department;
                ";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("----- EMPLOYEES WITH DEPARTMENT NAME -----");

                while (reader.Read())
                {
                    Console.WriteLine(
                        $"EmpID: {reader["EmpID"]}, " +
                        $"Name: {reader["EmpName"]}, " +
                        $"Salary: {reader["Salary"]}, " +
                        $"Department: {reader["DeptName"]}"
                    );
                }

                reader.NextResult();

                Console.WriteLine("\n----- DEPARTMENTS -----");

                while (reader.Read())
                {
                    Console.WriteLine(
                        $"DeptID: {reader["DeptID"]}, " +
                        $"DeptName: {reader["DeptName"]}"
                    );
                }

                reader.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        //Task 6
        public void GetEmployeeDetailsUsing()
        {
            if (con == null)
                throw new Exception("Connection object is null");

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                }
                catch
                {
                    throw new Exception("connection could not be opened");
                }
            }

            Console.WriteLine("Enter Employee ID:");
            int empId = Convert.ToInt32(Console.ReadLine());

            try
            {
                SqlCommand cmd = new SqlCommand("sp_GetEmployeeDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpID", empId);

                SqlParameter pJoin = new SqlParameter("@DateOfJoin", SqlDbType.Date);
                pJoin.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pJoin);

                SqlParameter pDept = new SqlParameter("@Department", SqlDbType.VarChar, 50);
                pDept.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pDept);

                cmd.ExecuteNonQuery();

                DateTime doj = (cmd.Parameters["@DateOfJoin"].Value == DBNull.Value)
                                ? DateTime.MinValue
                                : Convert.ToDateTime(cmd.Parameters["@DateOfJoin"].Value);

                string dept = cmd.Parameters["@Department"].Value?.ToString();

                Console.WriteLine("\n========= EMPLOYEE SUMMARY =========");
                Console.WriteLine($"Employee ID   : {empId}");
                Console.WriteLine($"Date of Join  : {doj:dd-MMM-yyyy}");
                Console.WriteLine($"Department    : {dept}");
                Console.WriteLine("====================================");

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

    }
}
