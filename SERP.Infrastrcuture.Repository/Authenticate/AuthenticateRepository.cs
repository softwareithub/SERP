using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SERP.Core.Repository.Authenticate;
using SERP.Core.ViewModelEntities.Authenticate;
using SERP.Infrastrcuture.Repository.Comman;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SERP.Infrastrcuture.Repository.Authenticate
{
    public class AuthenticateRepository : IAuthenticateRepository
    {
        private readonly string _connectionString;
        private readonly IConfiguration _configuration;

        public AuthenticateRepository(IConfiguration configuration)
        {
            this._connectionString = configuration.GetSection("SERPDBInfo:SERpDevelopmentDB").Value;
        }
        public async Task<StudentProfileVm> AuthenticateUser(string userName, string password)
        {
            StudentProfileVm model = new StudentProfileVm();
            SqlParameter[] sqlParams = {
                    new SqlParameter("@userName",userName),
                    new SqlParameter("@password",password)
            };
            var reader = await SqlHelperExtension.ExecuteReader(_connectionString, SqlConstant.usp_AuthenticateUsers, System.Data.CommandType.StoredProcedure, sqlParams);

            while (reader.Read())
            {
                model.StudentId = reader.DefaultIfNull<int>("Id");
                model.StudentName = reader.DefaultIfNull<string>("StudentName");
                model.FatherName = reader.DefaultIfNull<string>("FatherName");
                model.MotherName = reader.DefaultIfNull<string>("MotherName");
                model.RegistrationNumber = reader.DefaultIfNull<string>("RegistrationNumber");
                model.RollCode = reader.DefaultIfNull<string>("RollCode");
                model.ClassName = reader.DefaultIfNull<string>("className");
                model.BatchName = reader.DefaultIfNull<string>("BatchName");
                model.DateOfBirth = reader.DefaultIfNull<DateTime>("DateOfBirth");
                model.StudentEmail = reader.DefaultIfNull<string>("StudentEmail");
                model.StudentPhone = reader.DefaultIfNull<string>("StudentPhone");
                model.FatherEmail = reader.DefaultIfNull<string>("FatherEmail");
                model.FatherPhone = reader.DefaultIfNull<string>("FatherPhone");
                model.P_Address = reader.DefaultIfNull<string>("P_Address");
                model.C_Address = reader.DefaultIfNull<string>("C_Address");
                model.ParentPhoto = reader.DefaultIfNull<string>("ParentsPhoto");
                model.StudentPhoto = reader.DefaultIfNull<string>("StudentPhoto");
            }

            return model;
        }
    }
}
