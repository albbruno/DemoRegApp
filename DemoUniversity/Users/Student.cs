using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoUniversity;
using DemoUniversity.Courses;


namespace DemoUniversity.Users
{
    public class Student : Users
    {
        private enum ClassYear
        {
            Freshman,
            Sophmore,
            Junior,
            Senior
        }

        private string mMajor;

        private bool mIsFulltime;
    
        //public List<Courses.Courses> Classes = new List<Courses.Courses>();
        public Dictionary<string, Courses.Courses> ClassesDictionary = new Dictionary<string, Courses.Courses>();

        public Student(string firstName, string lastName, string password, string email, int id, string major = "Undecided", bool isFulltime = false) : base(firstName, lastName, password, email, id)
        {
            mMajor = major;
            mIsFulltime = isFulltime;
        }

        public bool AddCourse(Courses.Courses aCourse)
        {
            ClassesDictionary.Add(aCourse.CourseName, aCourse);

            return true;
        }

        public bool AddCourses(List<Courses.Courses> someCourses)
        {
            foreach(Courses.Courses aCourse in someCourses)
            {
                AddCourse(aCourse);
            }

            return true;
        }

        public bool AddCourses(Dictionary<string, Courses.Courses> someCourses)
        {
            foreach (KeyValuePair<string, Courses.Courses> aClass in someCourses)
            {
                AddCourse(aClass.Value);
            }

            return true;
        }

        public override string GetInfo()
        {

            StringBuilder data = new StringBuilder();

            data.Append($"{base.ToString()} \nMajor: {mMajor} \nFulltime: {mIsFulltime} \n");
            data.Append("Courses:\n");


            //string info = $"{base.ToString()} /n Major: {mMajor} /n Fulltime: {mIsFulltime} ";
            //info += "Courses:/t";

            if (ClassesDictionary.Count == 0)
            {
                data.Append("Not Registered");
            }
            else
            {
                foreach (KeyValuePair<string, Courses.Courses> aClass in ClassesDictionary)
                {
                    data.Append($"{aClass.Value.CourseName}\n");
                    //info += $"{aClass.CourseName}/t";
                }
            }
        
            return data.ToString();
        }
    }
}
