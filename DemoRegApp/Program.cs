using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoUniversity;
using DemoUniversity.Courses;
using DemoUniversity.Users;


namespace DemoRegApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region student output test case
            Console.ReadLine();

            Console.WriteLine("putting in dummy data and showing it \n");

            Student someStudent = new Student("Alain", "Bruno", "poopinabottle123", "poopermail@poopmail.poop", 1);

            Courses someCourse = new Courses("How To Poop", new DateTime(1993, 07, 06));

            someStudent.AddCourse(someCourse);

            someCourse = new Courses("What To Poop", new DateTime(1885, 07, 06));

            someStudent.AddCourse(someCourse);

            someCourse = new Courses("Why To Poop", new DateTime(5974, 07, 06));

            someStudent.AddCourse(someCourse);

            someCourse = new Courses("When To Poop", new DateTime(1993, 07, 06));

            someStudent.AddCourse(someCourse);

            someCourse = new Courses("Where To Poop", new DateTime(1993, 07, 06));

            someStudent.AddCourse(someCourse);

            someCourse = new Courses("If You Should Actually Poop", new DateTime(1993, 07, 06));

            someStudent.AddCourse(someCourse);

            Console.WriteLine("Done With Dummy Data \n");

            Console.WriteLine(someStudent.GetInfo());

            Console.ReadLine();
            #endregion student output test case


            #region test cases

            /*
            Courses testCourse = new Courses();

            Student tStudent = new Student("Jack", "Jiff", "Poop","Poop@poopmail.com", 3);

            List<Student> sList = new List<Student>();

            Console.WriteLine(testCourse.GetStudentRoster().Count);

            testCourse.AddStudent(tStudent);

            Console.WriteLine(testCourse.CourseCount);

            Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                testCourse.AddStudent(tStudent);
            }

            Console.WriteLine(testCourse.GetStudentRoster().Count);

            Console.ReadLine();

            sList.Clear();

            for (int i = 0; i < 30; i++)
            {
                sList.Add(tStudent);
            }

            try
            {
                testCourse.AddStudents(sList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine(ex.ToString());
            }

            Console.ReadLine();
            */
            #endregion test cases
        }
    }
}
