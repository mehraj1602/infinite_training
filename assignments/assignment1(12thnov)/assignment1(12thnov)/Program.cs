using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_12thnov_
{
     class Program
    {
        static void Main()
        {
            ArrayList orderList = new ArrayList();

            orderList.Add(new Order(101, "Alice", 350.50m));
            orderList.Add(new Order(102, "Bob", 499.99m));
            orderList.Add(new Order(103, "Charlie", 250.00m));

            int choice;

            do
            {
                Console.WriteLine("\n=== FOODIFY ORDER MANAGEMENT ===");
                Console.WriteLine("1. Add New Order");
                Console.WriteLine("2. Display All Orders");
                Console.WriteLine("3. Search Order by ID");
                Console.WriteLine("4. Remove Order by ID");
                Console.WriteLine("5. Show Total Number of Orders");
                Console.WriteLine("6. Sort Orders by Amount");
                Console.WriteLine("7. Reverse Order List");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddOrder(orderList);
                        break;
                    case 2:
                        DisplayOrders(orderList);
                        break;
                    case 3:
                        SearchOrder(orderList);
                        break;
                    case 4:
                        RemoveOrder(orderList);
                        break;
                    case 5:
                        Console.WriteLine($"\nTotal Orders: {orderList.Count}");
                        break;
                    case 6:
                        SortOrders(orderList);
                        break;
                    case 7:
                        orderList.Reverse();
                        Console.WriteLine("\nList reversed successfully!");
                        break;
                    case 8:
                        Console.WriteLine("\nExiting program...");
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice! Try again.");
                        break;
                }

            } while (choice != 8);
        }

        static void AddOrder(ArrayList orderList)
        {
            Console.Write("\nEnter Order ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Total Amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            orderList.Add(new Order(id, name, amount));
            Console.WriteLine("\nOrder added successfully!");
        }

        static void DisplayOrders(ArrayList orderList)
        {
            if (orderList.Count == 0)
            {
                Console.WriteLine("\nNo orders to display.");
                return;
            }

            Console.WriteLine("\n--- Current Orders ---");
            foreach (Order order in orderList)
            {
                Console.WriteLine(order);
            }
        }

        static void SearchOrder(ArrayList orderList)
        {
            Console.Write("\nEnter Order ID to search: ");
            int searchId = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            foreach (Order order in orderList)
            {
                if (order.OrderID == searchId)
                {
                    Console.WriteLine("\nOrder found: " + order);
                    found = true;
                    break;
                }
            }
            if (!found)
                Console.WriteLine("\nOrder not found!");
        }

        static void RemoveOrder(ArrayList orderList)
        {
            Console.Write("\nEnter Order ID to remove: ");
            int removeId = Convert.ToInt32(Console.ReadLine());

            Order orderToRemove = null;

            foreach (Order order in orderList)
            {
                if (order.OrderID == removeId)
                {
                    orderToRemove = order;
                    break;
                }
            }

            if (orderToRemove != null)
            {
                orderList.Remove(orderToRemove);
                Console.WriteLine("\nOrder removed successfully!");
            }
            else
            {
                Console.WriteLine("\nOrder not found!");
            }
        }

        static void SortOrders(ArrayList orderList)
        {
            if (orderList.Count == 0)
            {
                Console.WriteLine("\nNo orders to sort.");
                return;
            }

            // Simple Bubble Sort based on TotalAmount
            for (int i = 0; i < orderList.Count - 1; i++)
            {
                for (int j = 0; j < orderList.Count - i - 1; j++)
                {
                    Order o1 = (Order)orderList[j];
                    Order o2 = (Order)orderList[j + 1];

                    if (o1.TotalAmount > o2.TotalAmount)
                    {
                        Order temp = o1;
                        orderList[j] = o2;
                        orderList[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\n--- Orders Sorted by Amount ---");
            foreach (Order order in orderList)
            {
                Console.WriteLine(order);
            }
        }
    }
}