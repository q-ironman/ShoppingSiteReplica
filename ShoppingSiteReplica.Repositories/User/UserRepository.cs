using ShoppingSiteReplica.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ShoppingSiteReplica.Repositories
{
    public class UserRepository : IUserRepository
    {
        string path = @"C:\Users\osman\Desktop\Lectures\C#\ShoppingSiteReplica\ShoppingSiteReplica\Users.xml";
        XElement doc;
        public UserRepository()
        {
            doc = XElement.Load(path);
            
        }

        public User Get(UserSearch userSearch)
        {
            var element = doc.Elements("User").FirstOrDefault(x => x.Element("Email").Value.ToString() == userSearch.Email && x.Element("Password").Value.ToString() == userSearch.Password);
            if (element == null)
                return null;
            User res = new User();
            res.Email = element.Element("Email").Value;
            res.UserID = Convert.ToInt32(element.Element("UserID").Value);
            res.Name = element.Element("Name").Value;
            res.LastName = element.Element("LastName").Value;
            res.Password = element.Element("Password").Value;

            
            return res;

        }

        public List<User> GetAll()
        {

            IEnumerable<XElement> allUsers = doc.Elements();
            List<User> res = new List<User>();
            foreach(var user in allUsers)
            {
                User tmp = new User();
                tmp.UserID = Convert.ToInt32(user.Element("UserID").Value);
                tmp.Name = user.Element("Name").Value;
                tmp.LastName = user.Element("LastName").Value;
                tmp.Email = user.Element("Email").Value;
                tmp.Password = user.Element("Password").Value;
                res.Add(tmp);
            }

            return res;
        }
    }
}
