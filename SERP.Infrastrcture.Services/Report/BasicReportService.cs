using SERP.Core.Repository.Report;
using SERP.Core.Services.Report;
using SERP.Core.ViewModelEntities.BasicReport;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SERP.Infrastrcture.Services.Report
{
    public class BasicReportService: IBasicReportService
    {
        private readonly IBasicReportRepoSitory _basicReportRepoSitory;
        public BasicReportService(IBasicReportRepoSitory basicReportRepoSitory)
        {
            _basicReportRepoSitory = basicReportRepoSitory;
        }

        public async Task<List<StudentClassWiseCount>> GetStudentClassWiseCount()
        {
            return await _basicReportRepoSitory.GetStudentClassWiseCount();
        }
    }
}
