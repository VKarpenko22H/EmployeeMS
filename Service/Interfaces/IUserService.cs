using DataAccess.Entities;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserModel> GetUsers();
        IEnumerable<UserModel> CreateUser(User newUserModel);

    }
}
