using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_12thnov_
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }

        public Order(int orderID, string customerName, decimal totalAmount)
        {
            OrderID = orderID;
            CustomerName = customerName;
            TotalAmount = totalAmount;
        }

        public override string ToString()
        {
            return $"Order ID: {OrderID}, Customer: {CustomerName}, Amount: {TotalAmount:C}";
        }
    }
}
