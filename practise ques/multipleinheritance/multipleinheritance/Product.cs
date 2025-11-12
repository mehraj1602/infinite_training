using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleinheritance
{
    interface IProduct
    {
        void GetProductInfo();
        void DisplayProductInfo();
    }

    interface IReview
    {

        void GetReviews();
        void DisplayReviews();
    }

    public class Customer : IProduct, IReview
    {
        int ProductId { get; set; }
        string ProductName { get; set; }
        double Price { get; set; }
        public static int ReviewId { get; set; } = 0;
        public string Comments { get; set; }
        public int Ratings { get; set; }
        public int CustomerProductId { get; set; }


        public void GetProductInfo()
        {
            Console.WriteLine("Enter the productId,Name,Price");
            ProductId = Convert.ToInt32(Console.ReadLine());
            ProductName = Console.ReadLine();
            Price = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine("ProductId: " + ProductId);
            Console.WriteLine("ProductName: " + ProductName);
            Console.WriteLine("Price: " + Price);
        }

        public void GetReviews()
        {
            Console.WriteLine("Enter the ProductId, Comments, Rating(1-5)");
            ProductId = Convert.ToInt32(Console.ReadLine());
            Comments = Console.ReadLine();
            Ratings = Convert.ToInt32(Console.ReadLine());
            ReviewId++;
        }

        public void DisplayReviews()
        {
            Console.WriteLine("ReviewId: " + ReviewId);
            Console.WriteLine("ProductId: " + ProductId);
            Console.WriteLine("Comments: " + Comments);
            Console.WriteLine("Ratings: " + Ratings);
        }


    }
}
