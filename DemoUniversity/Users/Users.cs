using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUniversity.Users
{
    /// <summary>
    /// generic user class
    /// </summary>
    public abstract class Users
    {
        #region fields
        private string mFName;
        private string mLName;
        protected string mPassword;
        private string mEmail;
        private int mId; //guid id
        #endregion fields

        #region properties
        public string FullName { get { return $"{mFName} {mLName}"; } }
        public string FirstName { get { return mFName; } set { mFName = value; } }
        public string LastName { get { return mLName; } set { mLName = value; } }
        public string Password { get { return mPassword; } set { mPassword = value; } }
        public string Email { get { return mEmail; } set { mEmail = value; } }
        public int Id { get { return mId; } }
        #endregion properties

        public abstract string GetInfo();

        #region ctors
        /// <summary>
        /// generic user class
        /// </summary>
        public Users()
        {

        }
        /// <summary>
        /// user constructor
        /// </summary>
        /// <param name="name">person's name</param>
        /// <param name="password">user password</param>
        /// <param name="email">user email</param>
        /// <param name="id">user id</param>
        public Users(string firstName, string lastName, string password, string email, int id)
        {

            mFName = firstName;
            mLName = lastName;
            mPassword = password;
            mEmail = email;
            mId = id;

        }

        #endregion ctors


        public override string ToString()
        {
            string results = ""; //= $"{FullName} \n********** \n Email: {Email}";

            results += FullName;
            results += "\n";
            results += "Password:*****************";
            results += "\n";
            results += $"Email: {Email}";


            return results;
        }


    }
}
