using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment12thDec
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // ConnectedClass connectedClass = new ConnectedClass();
            // connectedClass.DisplayAllCourses();

            //connectedClass.AddStudent();

            //connectedClass.SearchStudentDepartment();

            //connectedClass.EnrolledCourses();

            // connectedClass.UpdateGrade();

            DisconnectedClass disconnectedClass = new DisconnectedClass();
            //disconnectedClass.LoadStudentCourse();

            //disconnectedClass.ModifyCredits();

            //disconnectedClass.InsertNewCourse();

            //disconnectedClass.DeleteStudent();

            disconnectedClass.GetCoursesBySemester_SP();


        }

    }
}
