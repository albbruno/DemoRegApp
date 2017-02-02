using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUsers
{
    public class Administrator : Users
    {

        public void SetPassword(string password)
        {
            mPassword = password;
        }

    }
}
