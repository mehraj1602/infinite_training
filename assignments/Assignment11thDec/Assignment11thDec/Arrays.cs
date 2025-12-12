using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11thDec
{
    internal class Arrays
    {
        List<int> listA = new List<int> { 10, 20, 30, 40, 50, 20, 30 };
        List<int> listB = new List<int> { 30, 40, 50, 60, 70, 40 };

        List<string> names1 = new List<string> { "Akshay", "Aasritha", "Deepa", "Kiran","Kiran" };
        List<string> names2 = new List<string> { "Kiran", "Manikanta", "Deepa", "Naveen" };

        public void arrayfunc()
        {

            //Q1. Write a LINQ query to fetch unique values from listA.
            //var result = listA.Distinct();
            //Console.WriteLine(string.Join(", ", result));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            //Q2. Combine values from listA and listB without duplicates. 
            //var result = listA.Union(listB);
            //Console.WriteLine(string.Join(", ", result));



            //Q3. Find items common in listA and listB. 
            // var result = listA.Intersect(listB);
            //Console.WriteLine(string.Join(", ", result));


            //Q4. Find names present in names1 but not in names2.
            //var result = names1.Except(names2);
            //Console.WriteLine(string.Join(", ", result));


            productcls productcls = new productcls();
            //Q5. Find sum of price of all products.
            //var res = productcls.GetProducts().Sum(p => p.price);
            //Console.WriteLine("Total Price : " + res);

            //Q6. Find count of products where price > 5000. 
            //var res = productcls.GetProducts().Count(p => p.price > 5000);
            //Console.WriteLine(res);

            //Q7. Find the highest value in listA. 
            //var res = listA.Max();
            //Console.WriteLine(res);

            //Q8. Write a LINQ query to find numbers divisible by 3 
            //int[] numbers = { 1, 4, 9, 16, 25, 36 };
            //var res = from n in numbers
            //          where n % 3 == 0
            //          select n;
            //Console.WriteLine(string.Join(", " , res));

            //Q9.Write a Linq to query to sort based on string Length
            string[] st = { "India", "Srilanka", "canada", "Singapore" };
            var res = from s in st
                      orderby s.Length
                      select s;
            Console.WriteLine(string.Join(", ", res));







        }
    }
}
