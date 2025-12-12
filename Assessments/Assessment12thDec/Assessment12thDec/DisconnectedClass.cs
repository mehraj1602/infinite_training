using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment12thDec
{
    internal class DisconnectedClass
    {
        SqlConnection con;
        public DisconnectedClass()
        {
            con = new SqlConnection("uid=sa;pwd=Infinite@2025;database=EduTrack;server=ICS-LT-BJ43YS3");
        }


        //Task 3.1 – Load Students and Courses into a DataSet

        public void LoadStudentCourse()
        {
            SqlDataAdapter daStudents = new SqlDataAdapter("select * from Students", con);
            SqlDataAdapter daCourses = new SqlDataAdapter("select * from Courses", con);
            DataSet ds = new DataSet();
            daStudents.Fill(ds, "Students");
            daCourses.Fill(ds, "Courses");

            DataTable tS = ds.Tables["Students"];
            DataTable tC = ds.Tables["Courses"];

            Console.WriteLine("Students");

            foreach (DataRow r in tS.Rows)

                Console.WriteLine($"{r["StudentId"]} | {r["FullName"]} | {r["Email"]} | {r["Department"]} | {r["YearOfStudy"]}");

            Console.WriteLine("\nCourses ");

            foreach (DataRow r in tC.Rows)

                Console.WriteLine($"{r["CourseId"]} | {r["CourseName"]} | {r["Credits"]} | {r["Semester"]}");
        }

        //Task 3.2 – Modify course credits (Disconnected Mode)

        public void ModifyCredits()
        {
            SqlDataAdapter da = new SqlDataAdapter("select CourseId, CourseName, Credits, Semester from Courses", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();

            da.Fill(ds, "Courses");
            DataTable dt = ds.Tables["Courses"];
            Console.Write("Enter the CourseId to update credits: ");

            int cid = int.Parse(Console.ReadLine());
            Console.Write("Enter the new Credits (int): ");

            int newCredits = int.Parse(Console.ReadLine());
            DataRow row = dt.Select($"CourseId = {cid}").FirstOrDefault();

            if (row != null)
            {
                row["Credits"] = newCredits;
                int updated = da.Update(dt);
                Console.WriteLine($"Rows are updated: {updated}");
            }
            else
            {
                Console.WriteLine("CourseId is not found.");
            }
        }

        //Task 3.3 – Insert a new course (Disconnected Mode)

        public void InsertNewCourse()
        {
            SqlDataAdapter da = new SqlDataAdapter("select CourseId, CourseName, Credits, Semester from Courses", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Courses");

            DataTable dt = ds.Tables["Courses"];
            Console.Write("Course Name: ");

            string name = Console.ReadLine();
            Console.Write("Credits (int): ");

            int credits = int.Parse(Console.ReadLine());
            Console.Write("Semester: ");

            string sem = Console.ReadLine();
            DataRow newRow = dt.NewRow();


            newRow["CourseName"] = name;
            newRow["Credits"] = credits;
            newRow["Semester"] = sem;
            dt.Rows.Add(newRow);

            int inserted = da.Update(dt);
            Console.WriteLine($"Rows inserted: {inserted}");

        }

        //Task 3.4 – Delete a student (Disconnected Mode)
        
        public void DeleteStudent()
        {
            SqlDataAdapter da = new SqlDataAdapter("select StudentId, FullName, Email, Department, YearOfStudy from Students", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Students");

            DataTable dt = ds.Tables["Students"];
            Console.Write("Enter StudentId to delete: ");

            int sid = int.Parse(Console.ReadLine());

            DataRow row = dt.Select($"StudentId = {sid}").FirstOrDefault();

            if (row != null)
            {
                row.Delete();         
                int affected = da.Update(dt);
                Console.WriteLine($"Rows deleted: {affected}");
            }
            else
            {
                Console.WriteLine("StudentId not found.");
            }
        }

        //Stored Procedure

        public  void GetCoursesBySemester_SP()

        {
          Console.Write("Enter semester: ");
             string semester = Console.ReadLine();
            {

                SqlDataAdapter da = new SqlDataAdapter("usp_GetCoursesBySemester", con);

                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@semester", semester);

                DataSet ds = new DataSet();
                da.Fill(ds, "Courses");
                DataTable dt = ds.Tables["Courses"];

                Console.WriteLine("\nCourseId | CourseName | Credits | Semester");
                foreach (DataRow r in dt.Rows)
                {

                    Console.WriteLine($"{r["CourseId"]} | {r["CourseName"]} | {r["Credits"]} | {r["Semester"]}");

                }

            }

        }


    }



}
