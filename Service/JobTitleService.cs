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

namespace Service
{
    
    public class JobTitleService: IJobTitleService
    {
        private readonly IJobTitleRepository repository;
        private readonly IMapper mapper;
        public JobTitleService(IJobTitleRepository jobTitleRepository, IMapper mapper)
        {
            repository = jobTitleRepository;
            this.mapper = mapper;
        }


        

            public IEnumerable<JobTitleModel> GetJobTitles()
            {
                var dbJobTitles = repository.GetAll();
            return mapper.Map<IEnumerable<JobTitleModel>>(dbJobTitles);

            
            }
        public IEnumerable<JobTitleModel> CreateJobTitle(JobTitle jobTitle)
        {
            var dbJobTitles = repository.CreateJobTitle(jobTitle);
            return mapper.Map<IEnumerable<JobTitleModel>>(dbJobTitles);
        }

    }
}
