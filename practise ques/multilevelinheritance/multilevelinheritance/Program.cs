using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace multilevelinheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor();
            Professor professor1 = new Professor() {Name = "peter" , Course = "Maths"};
            professor.Name = "Test";
            professor.Course = "AWS";
            professor.showName();
            professor.showCourse();
            professor.ConductResearch();
            Console.ReadLine();
            
          
            
        }
    }
}
