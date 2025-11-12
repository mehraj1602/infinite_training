using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            Console.WriteLine("Initial Capacity" + arrayList.Capacity);

            arrayList.Add(10);
            Console.WriteLine("Capacity after adding First Item" + arrayList.Capacity);

            arrayList.Add("Test Item 1");
            arrayList.Add(true);
            arrayList.Add(15.5);

            Console.WriteLine("Capacity after adding Four Items" + arrayList.Capacity);

            Console.WriteLine("\nItems in ArrayList are");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Remove(true);

            Console.WriteLine("After removing true arrayList items are");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After removing true capacity" + arrayList.Capacity);

            arrayList.Add("Anvith");
            arrayList.Add("Keerthana");
            arrayList.Add("Aasritha");
            arrayList.Insert(1, "New Item At Index 1");
            Console.WriteLine("After Adding 7 values capacity" + arrayList.Capacity);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            ArrayList arrayList2 = new ArrayList();
            arrayList2.Add("First Item in arrayList2");
            arrayList2.Add("Second Item in arrayList2");
            arrayList.AddRange(arrayList2);

            Console.WriteLine("After adding 9 values capacity" + arrayList.Capacity);

            ArrayList deptList = new ArrayList() { "IT", "HR", "Admin", "Finance" };
            arrayList.InsertRange(2, deptList);

            Console.WriteLine("After inserting deptList in the index position 2 in arrayList");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After adding 13 values capacity" + arrayList.Capacity);

            Console.WriteLine($"HR is there in arrayList or not? {arrayList.Contains("HR")}");

            Console.WriteLine("Total count" + arrayList.Count);

            Console.WriteLine($"arrayList[4] : {arrayList[4]}");

            //GetRange
            ArrayList arrayList3 = arrayList.GetRange(3, 5);
            Console.WriteLine("arrayList3 values are");
            foreach (var item in arrayList3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After reversing ArrayList 3");
            arrayList3.Reverse();
            foreach (var item in arrayList3)
            {
                Console.WriteLine(item);
            }

            //Remove range
            Console.WriteLine("After RemoveRange(2,2) ArrayList3");
            arrayList3.RemoveRange(2, 2);
            foreach (var item in arrayList3)
            {
                Console.WriteLine(item);
            }

            //RemoveAt
            Console.WriteLine("After RemoveAt(1) ArrayList 3");
            arrayList3.RemoveAt(1);
            foreach (var item in arrayList3)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
    }

