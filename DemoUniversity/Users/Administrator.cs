using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUniversity.Users
{
    public class Administrator : Users
    {
        public override string GetInfo()
        {
            return base.ToString();
        }

        public void SetPassword(string password)
        {
            mPassword = password;
        }

    }
}
