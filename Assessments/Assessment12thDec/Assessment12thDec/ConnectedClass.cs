using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment12thDec
{
    internal class ConnectedClass
    {
        SqlConnection con;
        public ConnectedClass()
        {
            con = new SqlConnection("uid=sa;pwd=Infinite@2025;database=EduTrack;server=ICS-LT-BJ43YS3");

        }

        //Task 2.1 – Display all courses
        public void DisplayAllCourses()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select CourseId, CourseName, Credits, Semester from Courses", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]} | {dr[1]} | {dr[2]} | {dr[3]}");
            }

            con.Close();
        }

        //Task 2.2 – Add a new student
        public void AddStudent()
        {
            con.Open();
            Console.WriteLine("Enter full name:");
            string fullName = Console.ReadLine();

            Console.WriteLine("Enter the email id:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter the department:");
            string department = Console.ReadLine();

            Console.WriteLine("Enter the year :");
            int year = int.Parse(Console.ReadLine());


            SqlCommand cmd = new SqlCommand( "insert into Students(FullName,Email,Department,YearOfStudy) VALUES(@n,@e,@d,@y)", con);
            cmd.Parameters.AddWithValue("@n", fullName);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@d", department);
            cmd.Parameters.AddWithValue("@y", year);

            cmd.ExecuteNonQuery();

            Console.WriteLine("Student Added ");
            con .Close();   
        }

        //Task 2.3 – Search students by department 

        public void SearchStudentDepartment()
        {
            con.Open();

            Console.WriteLine("Enter the Department");
            string department = Console.ReadLine();

            SqlCommand cmd = new SqlCommand ("SELECT StudentId, FullName, Email from Students where Department = @dept", con);
            cmd.Parameters.AddWithValue("@dept", department);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]}|{dr[1]}|{dr[2]}");
            }
            con.Close();
        }

        //Task 2.4 – Display enrolled courses for a student

        public void EnrolledCourses()
        {
            con.Open();
            Console.WriteLine("Enter the StudentId");
            int studentId = int.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand(@"select c.CourseName, c.Credits, e.EnrollDate, e.Grade from Enrollments e inner join Courses c ON e.CourseId = c.CourseId where e.StudentId = @sid", con);
            cmd.Parameters.AddWithValue("@sid", studentId);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]} | {dr[1]} | {dr[2]} | {dr[3]}");
            }
            con.Close();
        }

        //Task 2.5 – Update grade (Connected Mode)

        public void UpdateGrade()
        {
            con.Open();
            Console.WriteLine("Enter the Grade");
            string grade = Console.ReadLine();

            Console.WriteLine("Enter the enrollmentId ");
            int enrollmentId = int.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("update Enrollments SET Grade = @g where EnrollmentId = @id", con);
            cmd.Parameters.AddWithValue("@g", grade);
            cmd.Parameters.AddWithValue("@id", enrollmentId);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Grade Updated");
        }
    }
}
