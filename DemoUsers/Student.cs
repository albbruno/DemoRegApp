using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUsers
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

        public Student(string firstName, string lastName, string password, string email, int id, string major = "Undecided", bool isFulltime = false) : base(firstName, lastName, password, email, id)
        {
            mMajor = major;
            mIsFulltime = isFulltime;
        }

    }
}
