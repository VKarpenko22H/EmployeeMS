using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {




        IEnumerable<User> GetAllUsers();

        IEnumerable<User> CreateUser(User newUserModel);
       



    }
}
