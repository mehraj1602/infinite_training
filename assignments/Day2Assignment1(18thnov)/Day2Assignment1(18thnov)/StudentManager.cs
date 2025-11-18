using Day2Assignment1_18thnov_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day2Assignment1_18thnov_
{
    public class StudentManager
    {
        // 1. Dictionary initializer
        Dictionary<int, Student> students = new Dictionary<int, Student>()
    {
        { 1, new Student { Name="Rehan", Class="10A", TotalMarks=450, Gender='M'} },
        { 2, new Student { Name="Ayesha", Class="10B", TotalMarks=320, Gender='F'} },
        { 3, new Student { Name="Rohan", Class="9C", TotalMarks=280, Gender='M'} }
    };

        // 2. Show all students
        public async Task ShowAllStudents()
        {
            try
            {
                await Task.Delay(10); // To use await inside method

                foreach (var s in students)
                    WriteLine($"{s.Key} → {s.Value}");
            }
            catch (Exception ex)
            {
                await Task.Delay(10);
                WriteLine($"Error: {ex.Message}");
            }
        }

        // 3. GetStudentAsync method
        public async Task<Student> GetStudentAsync(int id)
        {
            try
            {
                return await Task.Run(() =>
                {
                    // If user didn't pass id → return default student
                    if (id == 0)
                        return new Student
                        {
                            Name = "Default",
                            Class = "NA",
                            TotalMarks = 0,
                            Gender = '-'
                        };

                    // Search in dictionary
                    if (!students.ContainsKey(id))
                        throw new Exception("Student not found");

                    var stu = students[id];

                    // If marks < 300 throw exception for catch filter
                    if (stu.TotalMarks < 300)
                        throw new Exception("less than 300");

                    return stu;
                });
            }
            catch (Exception ex) when (ex.Message.Contains("less than 300"))
            {
                await Task.Delay(10);
                WriteLine("Warning: Student marks are less than 300!");
                return null;
            }
            catch (Exception ex)
            {
                await Task.Delay(10);
                WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
    }
}

        