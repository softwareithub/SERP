using SERP.Core.ViewModelEntities.BasicReport;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SERP.Core.Repository.Report
{
    public interface IBasicReportRepoSitory
    {
        Task<List<StudentClassWiseCount>> GetStudentClassWiseCount();
    }
}
