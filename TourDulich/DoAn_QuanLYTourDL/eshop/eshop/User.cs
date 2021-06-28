using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop
{
    class User
    {
        string _username;
        string _password;
        public string uSerName
        {
            get { return _username; }
            set { _username = value; }
        }
           public string passWord
        {
            get { return _password; }
            set { _password = value; }
        }
        public User()
           {
           }
        public User(string user, string password)
        {
            _username = user;
            _password = password;
        }
    }
}
