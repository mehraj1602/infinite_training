using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DipDemo
{
    public class SqlDatabase : IDatabase
    {
        public void Save()


        {
            WriteLine("Saving to Sql");
        }
    }
}
