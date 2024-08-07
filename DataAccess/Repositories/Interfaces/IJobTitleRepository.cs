using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IJobTitleRepository : IRepository<JobTitle>
    {
        

        IEnumerable<JobTitle> GetFullJobTitles();

        IEnumerable<JobTitle> CreateJobTitle(JobTitle jobTitle);

    }
}
