using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevelinheritance
{
    public class Person
    {
        public Person()

        {
            Console.WriteLine(" Person constructor called");


        }
        public string Name;
        public void showName() => Console.WriteLine($"Name : {Name}");
    }
        class Teacher : Person
        {
            public Teacher()
            {
                Console.WriteLine("Teacher constructor");


            }
        public string Course;
        public void showCourse() => Console.WriteLine($"{Name} teaches {Course}");

        }
    class Professor : Teacher
    {
        public Professor()
        {
            Console.WriteLine("professor Constructor");
        }
        public void ConductResearch() => Console.WriteLine($"{Name} is conducting R&D in {Course}");


    
    }
}
