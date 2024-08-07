using AutoMapper;
using DataAccess.Entities;
using Service.Models;

namespace EmployeeMS.Configuration
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            CreateMap<JobTitleModel, JobTitle>().ReverseMap();
            CreateMap<Employee, EmployeeModel>().ReverseMap();

        }
    }
}

