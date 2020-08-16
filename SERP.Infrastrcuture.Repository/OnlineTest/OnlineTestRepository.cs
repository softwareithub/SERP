using Microsoft.Extensions.Configuration;
using SERP.Core.Entities.Comman;
using SERP.Core.Entities.OnlineTest;
using SERP.Core.Repository.OnlineTest;
using SERP.Infrastrcuture.Repository.Comman;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace SERP.Infrastrcuture.Repository.OnlineTest
{
    public class OnlineTestRepository : IOnlineTestRepository
    {
        private readonly string _connectionString;

        public OnlineTestRepository(IConfiguration configuration)
        {
            this._connectionString = configuration.GetSection("SERPDBInfo:SERpDevelopmentDB").Value;
        }
        public async Task<List<TestDetail>> GetOnlineTestDetail(int studentId)
        {
            List<TestDetail> models = new List<TestDetail>();
            SqlParameter[] sqlParams = {
                    new SqlParameter("@studentId",studentId),
            };
            var reader = await SqlHelperExtension.ExecuteReader(_connectionString, SqlConstant.usp_GetTestDetails, System.Data.CommandType.StoredProcedure, sqlParams);

            while (reader.Read())
            {
                TestDetail model = new TestDetail();
                model.TestId = reader.DefaultIfNull<int>("Id");
                model.TestName = reader.DefaultIfNull<string>("TestName");
                model.TestDateTime = reader.DefaultIfNull<DateTime>("TestDateTime");
                model.TimeLimit = reader.DefaultIfNull<string>("TestTimeLimit");
                model.CourseName = reader.DefaultIfNull<string>("Name");
                model.BatchName = reader.DefaultIfNull<string>("BatchName");
                model.QuestionCount = reader.DefaultIfNull<int>("QuestionCount");

                models.Add(model);
            }

            return models;
        }

        public async Task<List<TestQuestionDetail>> GetTestQuestionDetails(int testId)
        {
            List<TestQuestionDetail> models = new List<TestQuestionDetail>();
            SqlParameter[] sqlParams = {
                    new SqlParameter("@TestId",testId),
            };
            var reader = await SqlHelperExtension.ExecuteReader(_connectionString, SqlConstant.usp_GetQuestionDetails, System.Data.CommandType.StoredProcedure, sqlParams);

            while (reader.Read())
            {
                TestQuestionDetail model = new TestQuestionDetail();
                model.TestId = reader.DefaultIfNull<int>("TestId");
                model.Option = reader.DefaultIfNull<string>("OptionData");
                model.OptionId = reader.DefaultIfNull<int>("OptionId");
                model.Question = reader.DefaultIfNull<string>("Question");
                model.QuestionId = reader.DefaultIfNull<int>("QuestionId");
                model.QuestionPoint = reader.DefaultIfNull<int>("QuestionPoint");

                models.Add(model);
            }

            return models;
        }

        public Task<ResponseStatus> UpSertAnswereSheet(UserAnswereSheet model)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseStatus> UpsertUserDetail(UserTestDetail userTestDetail)
        {
            SqlParameter[] sqlParams = {
              new SqlParameter("@testId",userTestDetail.TestId),
              new SqlParameter("@userId",userTestDetail.UserId),
              new SqlParameter("@testStatus",userTestDetail.TestStatus),
            };

            var response = await SqlHelperExtension.ExecuteScalar(_connectionString, SqlConstant.usp_UpsertUserDetails, System.Data.CommandType.StoredProcedure, sqlParams);

            return new ResponseStatus()
            {
                StatusCode = "200OK",
                StatusMessage = response.ToString()
            };
        }

       
    }
}
