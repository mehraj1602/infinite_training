using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assignment1
{

    public interface IMyinter
    {
        string ShowAllStudents();
        Student GetStudent(int id);

        //Task<Student> GetStudentAsync(int id);
    }
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; } = "12A";
        public int TotalMarks { get; set; } = 520;
        public char Gender { get; set; } = 'F';

        public override string ToString()
            => $"Name: {Name}, Class: {Class}, Total Marks: {TotalMarks}";
    }

}