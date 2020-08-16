using SERP.Core.ViewModelEntities.BasicReport;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SERP.Core.Services.Report
{
    public interface IBasicReportService
    {
        Task<List<StudentClassWiseCount>> GetStudentClassWiseCount();
    }
}
