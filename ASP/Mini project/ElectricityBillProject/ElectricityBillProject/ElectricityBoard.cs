using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ElectricityBillProject
{
    public class ElectricityBoard
    {
        public void AddBill(ElectricityBill ebill)
        {
            using (SqlConnection con = DBHandler.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "insert into ElectricityBill values(@no,@name,@units,@amt)", con);
                cmd.Parameters.AddWithValue("@no", ebill.ConsumerNumber);
                cmd.Parameters.AddWithValue("@name", ebill.ConsumerName);
                cmd.Parameters.AddWithValue("@units", ebill.UnitsConsumed);
                cmd.Parameters.AddWithValue("@amt", ebill.BillAmount);
                cmd.ExecuteNonQuery();
            }
        }

        public void CalculateBill(ElectricityBill ebill)
        {
            int units = ebill.UnitsConsumed;
            double amount = 0;

            if (units > 100)
            {
                units -= 100;
                if (units > 200)
                {
                    amount += 200 * 1.5;
                    units -= 200;
                }
                else { amount += units * 1.5; units = 0; }
            }

            if (units > 0)
            {
                if (units > 300)
                {
                    amount += 300 * 3.5;
                    units -= 300;
                }
                else { amount += units * 3.5; units = 0; }
            }

            if (units > 0)
            {
                if (units > 400)
                {
                    amount += 400 * 5.5;
                    units -= 400;
                }
                else { amount += units * 5.5; units = 0; }
            }

            if (units > 0)
                amount += units * 7.5;

            ebill.BillAmount = amount;
        }

        public List<ElectricityBill> Generate_N_BillDetails(int num)
        {
            List<ElectricityBill> list = new List<ElectricityBill>();

            using (SqlConnection con = DBHandler.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    $"select top {num} * from ElectricityBill order by Id desc", con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ElectricityBill eb = new ElectricityBill();
                    eb.ConsumerNumber = dr["consumer_number"].ToString();
                    eb.ConsumerName = dr["consumer_name"].ToString();
                    eb.UnitsConsumed = (int)dr["units_consumed"];
                    eb.BillAmount = (double)dr["bill_amount"];
                    list.Add(eb);
                }
            }
            return list;
        }
        public string GetConsumerName(string consumerNumber)
        {
            using (SqlConnection con = DBHandler.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "select consumer_name from ElectricityBill where consumer_number = @cno", con);

                cmd.Parameters.AddWithValue("@cno", consumerNumber);

                object result = cmd.ExecuteScalar();

                return result == null ? "" : result.ToString();
            }
        }
    }
}
