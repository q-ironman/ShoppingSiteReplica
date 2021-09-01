using System;
using System.Collections.Generic;
using System.Text;
using ShoppingSiteReplica.Domain;


namespace ShoppinSiteReplica.Services
{
    public interface IUserService
    {
        bool Login(UserSearch userLogin);
        List<User> GetAllService();
    }
}
