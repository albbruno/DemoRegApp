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
            Random rGen = new Random();

            #region student output test case
            Console.ReadLine();

            Console.WriteLine("putting in dummy data and showing it \n");

            #region Alain
            Student alainStudent = new Student("Alain", "Bruno", "poopinabottle123", "poopermail@poopmail.poop", 1);

            Courses courseOne = new Courses("How To Poop", new DateTime(1993, 07, 06));
            Courses courseTwo = new Courses("What To Poop", new DateTime(1885, 07, 06));
            Courses courseThree = new Courses("Why To Poop", new DateTime(5974, 07, 06));
            Courses courseFour = new Courses("When To Poop", new DateTime(1993, 07, 06));
            Courses courseFive = new Courses("Where To Poop", new DateTime(1993, 07, 06));
            Courses courseSix = new Courses("If You Should Actually Poop", new DateTime(1993, 07, 06));

            alainStudent.AddCourse(courseOne);
            alainStudent.AddCourse(courseTwo);
            alainStudent.AddCourse(courseThree);
            alainStudent.AddCourse(courseFour);
            alainStudent.AddCourse(courseFive);
            alainStudent.AddCourse(courseSix);

            #endregion Alain

            #region other students info
            Student Paul = new Student("Paul", "Marry", "paulpassword", "paulmail@paulmail.paul", 2);
            Student Jack = new Student("Jack", "Jarry", "jackpassword", "jackdude@jackmail.com", 3);
            Student Jill = new Student("jill", "January", "janraownvbo", "jillmail@jjjnomail.new", 4);
            Student Mom = new Student("Mom", "Mother", "mommomMotherMom", "mom@parent.parenting", 5);
            Student Guy = new Student("dude", "guy", "guydude", "dudeguy@guymandude.man", 6);
            Student Door = new Student("door", "bell", "doorbelldoor", "doorbell@doorstop.knob", 7);
            Student Board = new Student("white", "board", "whiteboard12", "dryerase@marker.permanent", 8);


            Paul.AddCourses(alainStudent.ClassesDictionary);
            Jack.AddCourses(alainStudent.ClassesDictionary);
            Jill.AddCourses(alainStudent.ClassesDictionary);
            Mom.AddCourses(alainStudent.ClassesDictionary);
            Guy.AddCourses(alainStudent.ClassesDictionary);
            Door.AddCourses(alainStudent.ClassesDictionary);
            Board.AddCourses(alainStudent.ClassesDictionary);
            #endregion other students info



            Console.WriteLine("Done With Dummy Data \n");

            #region outputing info
            Console.WriteLine(alainStudent.GetInfo());

            Console.WriteLine("\n");

            Console.WriteLine(Paul.GetInfo());

            Console.WriteLine("\n");

            Console.WriteLine(Jack.GetInfo());

            Console.WriteLine("\n");

            Console.WriteLine(Jill.GetInfo());

            Console.WriteLine("\n");

            Console.WriteLine(Mom.GetInfo());

            Console.WriteLine("\n");

            Console.WriteLine(Guy.GetInfo());

            Console.WriteLine("\n");

            Console.WriteLine(Door.GetInfo());

            Console.WriteLine("\n");

            Console.WriteLine(Board.GetInfo());

            Console.WriteLine("\n");
            #endregion outputting info


            Console.ReadLine();

            Student testFindStudet;

            testFindStudet = courseOne.GetStudent(rGen.Next(0, 8));

            Console.WriteLine(testFindStudet.GetInfo());

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
