using System;
using System.Collections.Generic;
using System.Text;

namespace SERP.Infrastrcuture.Repository.Comman
{
    public static class SqlConstant
    {
        public static string usp_GetStudentCountByClassSection = @"usp_GetStudentCountByClassSection";
        public static string usp_AuthenticateUsers = @"usp_AuthenticateUser";
        public static string usp_GetStudentAttandenceDetails = @"usp_GetStudentAttandenceDetails";

        #region OnlineTest
        public static string usp_GetTestDetails =@"usp_GetTestDetail";
        public static string usp_GetQuestionDetails = @"usp_GetQuestionOptionDetails";

        public static string usp_UpsertUserDetails = @"usp_InsertUserTestDetail";
        #endregion
    }
}
