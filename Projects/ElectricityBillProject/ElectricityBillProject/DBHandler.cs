using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ElectricityBillProject
{
    public class DBHandler
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["EBCon"].ConnectionString);
            con.Open();
            return con;
        }
    }
}