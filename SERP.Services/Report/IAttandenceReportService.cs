using SERP.Core.ViewModelEntities.BasicReport;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SERP.Core.Services.Report
{
    public interface IAttandenceReportService
    {
        Task<AttandenceReportVm> GetStudentAttandenceReportAsync(int year, int month, int studentId);
    }
}
