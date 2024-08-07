using DataAccess.Entities;
using DataAccess.Repositories.Interfaces;
using DataAccess.Repositories;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly StaffContext context;
        public UserRepository(StaffContext staffContext)
        : base(staffContext)
        {
            context = staffContext;
        }



        public IEnumerable<User> CreateUser(User newUserModel)
        {

            context.Add(newUserModel);
            context.SaveChanges();
            yield return newUserModel;
        }

        
        public IEnumerable<User> GetAllUsers() => context.Users.ToList();

    }
}


