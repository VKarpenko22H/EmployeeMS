using DataAccess;
using DataAccess.Entities;
using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class JobTitleRepository : Repository<JobTitle>, IJobTitleRepository
    { 
        private readonly StaffContext context;
    public JobTitleRepository(StaffContext staffContext)
    : base(staffContext)
    {
        context = staffContext;
    }
        public IEnumerable<JobTitle> CreateJobTitle(JobTitle jobTitle)
        {
            
            context.Add(jobTitle);
            context.SaveChanges();
            yield return jobTitle;
        }
       

        public IEnumerable<JobTitle>  GetFullJobTitles() => context.JobTitles.ToList();

        

        //IEnumerable<JobTitle> IJobTitleRepository.GetAllJobTitles()
        //{
        //    throw new NotImplementedException();
        //}
    }


}

