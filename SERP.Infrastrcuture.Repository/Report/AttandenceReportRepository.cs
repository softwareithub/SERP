using Microsoft.Extensions.Configuration;
using SERP.Core.Repository.Report;
using SERP.Core.ViewModelEntities.BasicReport;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SERP.Infrastrcuture.Repository.Report
{
    public class AttandenceReportRepository : IAttandenceReportRepository
    {

        private readonly string _connectionString;
        private readonly IConfiguration _configuration;
        public Task<AttandenceReportVm> GetStudentAttandenceReportAsync(int year, int month, int studentId)
        {
            throw new NotImplementedException();
        }
    }
}
