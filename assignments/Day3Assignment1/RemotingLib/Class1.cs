using Day3Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RemotingLib
{
    [Serializable]
    public class ServiceClass : MarshalByRefObject, IMyinter
    {
        private Dictionary<int, Student> students = new Dictionary<int, Student>()
        {
            {1,new Student {Name = "Syeda",Class="10th",TotalMarks=450,Gender='F'} },
            {2,new Student {Name = "Arwa",Class="9th",TotalMarks=250,Gender='M'} },
            {3,new Student {Name = "Zunaira",Class="7th",TotalMarks=550,Gender='F'} },
        };

        public string ShowAllStudents()
        {
            string result = "";
            foreach (var s in students)
                result += $"ID: {s.Key} => {s.Value.ToString()}\n";

            return result;
        }

        public Student GetStudent(int id = 0)
        {
            try
            {
                if (id == 0)
                {
                    return new Student
                    {
                        Name = "Raj",
                        Class = "10",
                        TotalMarks = 530,
                        Gender = 'M'
                    };
                }

                if (!students.ContainsKey(id))
                {
                    throw new Exception("Student not found");
                }

                Student stu = students[id];

                if (stu.TotalMarks < 300)
                {
                    throw new Exception("Mark less than 300");
                }
                return stu;

            }
            catch (Exception ex)
            {
                WriteLine($"General Error: {ex.Message}");
                return new Student();
            }

        }

        //public async Task<Student> GetStudentAsync(int id = 0)
        //{
        //    try
        //    {
        //        return await Task.Run(() =>
        //        {
        //            if (!students.ContainsKey(id))
        //            {
        //                return new Student
        //                {
        //                    Name = "Default",
        //                    Class = "N/A",
        //                    TotalMarks = 0,
        //                    Gender = '-'
        //                };
        //            }
        //            var st = students[id];
        //            if (st.TotalMarks < 300)
        //                throw new Exception("less than 500");
        //            return st;
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        if (ex.Message.Contains("less than 500"))
        //        {
        //            await Task.Delay(10);
        //            WriteLine("Exception occurred: " + ex.Message);
        //        }
        //        return null;
        //    }
        //}

    }
}