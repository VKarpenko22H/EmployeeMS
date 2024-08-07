using DataAccess.Entities;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IJobTitleService
    {
        IEnumerable<JobTitleModel> GetJobTitles();
        IEnumerable<JobTitleModel> CreateJobTitle(JobTitle jobTitle);
    }
}
