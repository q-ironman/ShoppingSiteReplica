using ShoppingSiteReplica.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSiteReplica.Repositories
{
    public interface IUserRepository
    {
        User Get(UserSearch userSearch);
        List<User> GetAll();
    }
}
