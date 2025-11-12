using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class HashtableDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Anvith");
            ht.Add(2, "keerthana");
            ht.Add("eid", "109");
            ht.Add("dept", "ID");
            ht.Add("loaction", "hyderabad");
            ht["email"] = "sample@mail.com";
            ht[56] = "Test Value";

            Console.WriteLine(" Hash table values are");
            Console.WriteLine(" first value : " + ht[1]);
            Console.WriteLine(" count of hash table : "+ht.Count);
            Console.WriteLine(" the key 56 is available or not : " + ht.ContainsValue(56));
            Console.WriteLine(" the value sample@mail.com is available or not : " + ht.ContainsValue(56));

            ht.Remove(2);
            Console.WriteLine(" \n Hash table keys are");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("Key: "+ item);

            }
            Console.WriteLine("\n, Hash table values are");
            foreach (var item in ht.Values)
            {
                Console.WriteLine("key : " + item);
            }
            Console.WriteLine("\n, Hash table keys and values are");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine( item.Key + " - " +item.Value );
            }
            object[] KeysArray = new object[ht.Keys.Count];
            ht.Keys.CopyTo( KeysArray, 0 );
            Console.WriteLine("\n after copying all keys into KeyArray");
            foreach (var item in KeysArray)
            {
                Console.WriteLine( item);
            }

            Hashtable ht2 = new Hashtable();
            foreach(DictionaryEntry item in ht)
            {
                ht2[item.Key] = item.Value;
            }
            ht.Clear();
            Console.WriteLine(" After clearing the hashtable " +ht.Count);
            Console.ReadLine();

        }
    }
}