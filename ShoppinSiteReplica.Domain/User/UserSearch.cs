using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSiteReplica.Domain
{
    public class UserSearch
    {
        string _email;
        string _password;
        public string Email { get { return this._email; } set { this._email = value; } }
        public string Password { get {return this._password; } set {this._password = value; } }

    }
}
