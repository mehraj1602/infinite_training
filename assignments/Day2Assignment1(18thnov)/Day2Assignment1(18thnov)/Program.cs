using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day2Assignment1_18thnov_
{
    public class Program
    {

        public static async Task Main()
        {
            StudentManager manager = new StudentManager();

            WriteLine("---- All Students ----");
            await manager.ShowAllStudents();

            WriteLine("\n---- Search Students ----");

            await manager.GetStudentAsync(2);   // Valid student
            await manager.GetStudentAsync(3);   // Marks < 300
            await manager.GetStudentAsync(0);   // Default student
            await manager.GetStudentAsync(10);  // Not found
        }
    }
}



