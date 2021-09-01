using ShoppingSiteReplica.Domain;
using ShoppingSiteReplica.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ShoppinSiteReplica.Services
{
    public class UserXmlServices : IUserService
    {
        
        public bool Login(UserSearch userLogin)
        {
            
            if (!String.IsNullOrEmpty(userLogin.Email))
            {
                if (!String.IsNullOrEmpty(userLogin.Password))
                {
                    var myRepo = ServiceActivator.Get<IUserRepository>();
                    var user = myRepo.Get(userLogin);
                    if (user != null)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }

            return false;
        }
        public List<User> GetAllService()
        {
            var repository = ServiceActivator.Get<IUserRepository>();
            List<User> resAll = repository.GetAll();


            return resAll;
        }
    }
}
