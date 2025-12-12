using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUDDemo ob = new CRUDDemo();
            ob.showallemployees();

            //ob.SearchRecord();
            // ob.AddRecord();
            //ob.DeleteRecord();
            //ob.UpdateRecord();

            Console.ReadLine();
        }
    }
}
