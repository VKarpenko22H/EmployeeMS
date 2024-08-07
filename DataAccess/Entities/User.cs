﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class User
    {

        public int Id { get; set; }
       
        public string Login { get; set; } = string.Empty;
        
        public string Password { get; set; } = string.Empty;
       
        public string PasswordConfirm { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

       // public static List<User> Users { get; set; } = new List<User>();
    }
}