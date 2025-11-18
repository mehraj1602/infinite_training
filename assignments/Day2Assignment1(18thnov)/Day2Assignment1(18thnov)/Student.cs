using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment1_18thnov_
{
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int TotalMarks { get; set; }
        public char Gender { get; set; }

        // Expression-bodied ToString()
        public override string ToString()
            => $"{Name}, Class: {Class}, Total Marks: {TotalMarks}";
    }
}
