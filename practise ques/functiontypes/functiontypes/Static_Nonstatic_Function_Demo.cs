using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functiontypes
{
    internal class Static_Nonstatic_Function_Demo
    {
            static int x;
            int y;
             void NonStaticMethod()
            {
                Console.WriteLine("Non Static Function");

            }
            static void StaticMethod()
            {
                Console.WriteLine("static functions");

            }
            static void Main(string[] args)
            {
                x = 500;
                Static_Nonstatic_Function_Demo staticobj = new Static_Nonstatic_Function_Demo();
                staticobj.y = 600;
                Console.WriteLine("static variable accessing without object" + x);
                Console.WriteLine("non static variable accessing through object" + staticobj.y);
                StaticMethod();
                staticobj.NonStaticMethod();
                Console.ReadLine();
            }
        }
    }

