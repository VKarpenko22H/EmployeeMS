using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using Service.Models;

namespace Service.Configuration
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration() 
        {
            CreateMap<JobTitle,JobTitleModel > ().ReverseMap();
            CreateMap<Employee, EmployeeModel>().ReverseMap();
            CreateMap<User, UserModel>().ReverseMap();

        }
    }
}


