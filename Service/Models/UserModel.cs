using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class UserModel
    {

        //public int Id { get; set; }
        public Guid Id { get; set; }
        
        public string Login { get; set; } = string.Empty;
        
        public string PasswordHash { get; set; } = string.Empty;

        //public static List<UserModel> UserModels { get; set; } = new List<UserModel>();

    }
    
    
}