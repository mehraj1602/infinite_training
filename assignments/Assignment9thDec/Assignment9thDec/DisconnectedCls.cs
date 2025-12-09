using System;
using System.Data;
using System.Data.SqlClient;

namespace adonetdemo
{
    internal class DisconnectedCls
    {
        SqlConnection con;
        SqlDataAdapter daEmp, daDept;
        DataSet ds;
        DataTable dt;
        public DisconnectedCls()
        {
            con = new SqlConnection("uid=sa;pwd=Infinite@2025;database=infinitedb;server=ICS-LT-BJ43YS3");
            ds = new DataSet();
        }

        // TASK 1
        
        public void ShowEmployeeAndDepartment()
        {
            daEmp = new SqlDataAdapter("select * from employee", con);
            daDept = new SqlDataAdapter("select * from department", con);
            daEmp.Fill(ds, "emp");
            daDept.Fill(ds, "dept");
            Console.WriteLine("Employee Table");
            foreach (DataRow row in ds.Tables["emp"].Rows)
            {
                Console.WriteLine(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4]);
            }
            Console.WriteLine("Department Table");
            foreach (DataRow row in ds.Tables["dept"].Rows)
            {
                Console.WriteLine(row[0] + " " + row[1]);
            }
        }

        // TASK 2

        public void EmployeeDataView()
        {
            daEmp = new SqlDataAdapter("select * from employee", con);
            dt = new DataTable();
            daEmp.Fill(dt);
            DataView dv = new DataView(dt);
            dv.RowFilter = "salary > 47000 and deptid = 10 and empname like 'M%'";
            dv.Sort = "empname ASC";
            Console.WriteLine("Filtered Employees");
            foreach (DataRowView row in dv)
            {
                Console.WriteLine(row[0] + " " + row[1] + " " + row[2]);
            }
        }

        // TASK 3
        
        public void TotalTables()
        {
            Console.WriteLine("Total No Of Tables in the DataSet = " + ds.Tables.Count);
        }

        // TASK 4
        
        public void ReaderToDataTable()
        {
            SqlCommand cmd = new SqlCommand("select * from department", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dtDept = new DataTable();
            dtDept.Load(dr);
            con.Close();

            Console.WriteLine("Deparment from Data Table");
            foreach (DataRow row in dtDept.Rows)
            {
                Console.WriteLine(row[0] + " " + row[1]);
            }
        }

        // TASK 5
        public void MergeCustomerOrders()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select * from customers", con);
            SqlDataAdapter da2 = new SqlDataAdapter("select * from orders", con);
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            da1.Fill(ds1, "customers");
            da2.Fill(ds2, "orders");
            ds1.Merge(ds2);
            Console.WriteLine("Merged Dataset");
            foreach (DataTable table in ds1.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (var item in row.ItemArray)
                        Console.Write(item + " ");

                    Console.WriteLine();
                }
            }
        }

        // TASK 6
       
        public void ReadXmlData()
        {
            DataSet dxml = new DataSet();
            dxml.ReadXml("C:\\Users\\mehrajf\\Infinite_training\\assignments\\CUSTOMER.xml");
            foreach (DataTable table in dxml.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                        Console.Write(row[i] + " ");

                    Console.WriteLine();
                }
            }
        }
    }
}