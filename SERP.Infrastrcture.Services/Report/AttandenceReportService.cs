using SERP.Core.Repository.Report;
using SERP.Core.Services.Report;
using SERP.Core.ViewModelEntities.BasicReport;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SERP.Infrastrcture.Services.Report
{
    public class AttandenceReportService : IAttandenceReportService
    {
        private readonly IAttandenceReportRepository _attandenceReport;

        public AttandenceReportService(IAttandenceReportRepository attandenceReport)
        {
            this._attandenceReport = attandenceReport;
        }
        public async  Task<AttandenceReportVm> GetStudentAttandenceReportAsync(int year, int month, int studentId)
        {
            return await _attandenceReport.GetStudentAttandenceReportAsync(year, month, studentId);
        }
    }
}
