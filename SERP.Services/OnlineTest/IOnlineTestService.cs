using SERP.Core.Entities.Comman;
using SERP.Core.Entities.OnlineTest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SERP.Core.Services.OnlineTest
{
    public interface IOnlineTestService
    {
        Task<List<TestDetail>> GetOnlineTestDetail(int studentId);
        Task<List<TestQuestionDetail>> GetTestQuestionDetails(int testId);
        Task<ResponseStatus> UpsertUserDetail(UserTestDetail userTestDetail);
        Task<ResponseStatus> UpSertAnswereSheet(UserAnswereSheet model);
    }
}
