using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ShoppingSiteReplica.Domain
{
    [Serializable, XmlRoot("User")]
    public class User
    {
        int _id;
        string _email;
        string _password;
        string _name;
        string _lastName;

        public int UserID { get { return this._id; }  set {this._id = value; } }
        public string Name { get { return this._name; } set {this._name = value; } }
        public string LastName { get {return this._lastName; } set { this._lastName = value; } }
        public string Email { 
            get { return this._email;  }
            set {
                this._email = value;
                
            
            } }
        public string Password { get { return this._password; } set { this._password = value; } }

    }
}
