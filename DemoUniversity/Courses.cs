using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoUniversity;
using DemoUniversity.Users;

namespace DemoUniversity.Courses
{
    public class Courses : iCourses
    {
        private List<Student> mStudentRoster = new List<Student>();
        private string mCourseName;
        private string mMajor;
        private DateTime mTimeOfDay;


        public bool IsFull
        {
            get
            {
                return mStudentRoster.Count == Global.maxStudents;
            }
        }

        public string CourseName
        {
            get
            {
                return mCourseName;
            }

            set
            {
                mCourseName = value;
            }
        }

        public int CreditHours
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime DateTime
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Majors
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }


        public Courses()
        {
            mCourseName = "SomeClass";
        }

        public Courses(string title, DateTime timeOfDay, string major = "elective")
        {
            mCourseName = title;
            mTimeOfDay = timeOfDay;
            mMajor = major;
        }

        public int CourseCount { get { return mStudentRoster.Count; } }

        public bool AddStudent(Student stdnt)
        {

            SpaceCheck(1 + mStudentRoster.Count);
            mStudentRoster.Add(stdnt);

            return true;
        }

        public bool AddStudents(List<Student> roster)
        {

            SpaceCheck(roster.Count + mStudentRoster.Count);

            foreach (Users.Student stdnt in mStudentRoster)
            {
                AddStudent(stdnt);
            }

            return true;
        }

        public List<Student> GetStudentRoster()
        {
            return mStudentRoster;
        }

        public bool RemoveStudent(Student stdnt)
        {
            throw new NotImplementedException();
        }

        public bool RemoveStudent(int id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveStudent(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        bool iCourses.AddStudent(Student stdnt)
        {
            throw new NotImplementedException();
        }

        private bool SpaceCheck(int newCount)
        {

            if (newCount > Global.maxStudents)
            {
                throw new Exception(Errors.notEnoughSpace);
            }

            return true;
        }
    }
}
