using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoUniversity;

namespace DemoUniversity
{
    interface iCourses
    {

        DateTime DateTime { get; set; }
        string CourseName { get; set; }
        int CreditHours { get; set; }
        int Majors { get; set; }
        bool IsFull { get; }
        int CourseCount { get; }

        bool AddStudent(Users.Student stdnt);
        bool AddStudents(List<Users.Student> roster);
        bool RemoveStudent(int id);
        bool RemoveStudent(Users.Student stdnt);
        bool RemoveStudent(string firstName, string lastName);
        List<Users.Student> GetStudentRoster();

    }
}
