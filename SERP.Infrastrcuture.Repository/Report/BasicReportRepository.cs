using Microsoft.Extensions.Configuration;
using SERP.Core.Repository.Report;
using SERP.Core.ViewModelEntities.BasicReport;
using SERP.Infrastrcuture.Repository.Comman;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SERP.Infrastrcuture.Repository.Report
{
    public class BasicReportRepository : IBasicReportRepoSitory
    {
        private readonly string _connectionString;
        private readonly IConfiguration _configuration;
        public BasicReportRepository(IConfiguration configuration)
        {
            this._connectionString = configuration.GetSection("SERPDBInfo:SERpDevelopmentDB").Value;
        }

        public async Task<List<StudentClassWiseCount>> GetStudentClassWiseCount()
        {
            List<StudentClassWiseCount> models = new List<StudentClassWiseCount>();
            var reader = await SqlHelperExtension.ExecuteReader(_connectionString, SqlConstant.usp_GetStudentCountByClassSection, System.Data.CommandType.StoredProcedure, null);

            while (reader.Read())
            {
                StudentClassWiseCount model = new StudentClassWiseCount();
                model.StudentCount = reader.DefaultIfNull<int>("studentCount");
                model.ClassName = reader.DefaultIfNull<string>("CourseName");
                model.BatchName = reader.DefaultIfNull<string>("BatchName");
                models.Add(model);
            }

            return models;
        }
    }
}
