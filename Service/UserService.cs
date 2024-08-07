using AutoMapper;
using DataAccess.Entities;
using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using Service.Interfaces;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            repository = userRepository;
            this.mapper = mapper;
        }
        public static string HashPassword(string password)
        {
            var byted = Encoding.UTF8.GetBytes(password);
            var sha1 = SHA1.Create();
            var hashedBytes = sha1.ComputeHash(byted);
            return Encoding.UTF8.GetString(hashedBytes);
        }

        public static bool IsCorrectPassword(UserModel user, string password)
        {
            var passwordHash = HashPassword(password);
            return passwordHash == user.PasswordHash;
        }
        public static List<UserModel> UserModels { get; set; } = new List<UserModel>();


        public IEnumerable<UserModel> GetUsers()
        {
            var dbUsers = repository.GetAll();

            return dbUsers.Select(e => new UserModel {});

        }
     
        public IEnumerable<UserModel> CreateUser(User newUserModel)
        {
            var dbUsers = repository.CreateUser(newUserModel);
            return mapper.Map<IEnumerable<UserModel>>(dbUsers);
        }

    }
}

