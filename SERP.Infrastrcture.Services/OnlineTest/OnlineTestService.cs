using SERP.Core.Entities.Comman;
using SERP.Core.Entities.OnlineTest;
using SERP.Core.Repository.OnlineTest;
using SERP.Core.Services.OnlineTest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SERP.Infrastrcture.Services.OnlineTest
{
    public class OnlineTestService : IOnlineTestService
    {
        private readonly IOnlineTestRepository _IOnlineTestRepository;

        public OnlineTestService(IOnlineTestRepository onlineTestRepository)
        {
            _IOnlineTestRepository = onlineTestRepository;
        }
        public async Task<List<TestDetail>> GetOnlineTestDetail(int studentId)
        {
            return await _IOnlineTestRepository.GetOnlineTestDetail(studentId);
        }

        public async Task<List<TestQuestionDetail>> GetTestQuestionDetails(int testId)
        {
            return await _IOnlineTestRepository.GetTestQuestionDetails(testId);
        }

        public async  Task<ResponseStatus> UpSertAnswereSheet(UserAnswereSheet model)
        {
            return await _IOnlineTestRepository.UpSertAnswereSheet(model);
        }

        public async  Task<ResponseStatus> UpsertUserDetail(UserTestDetail userTestDetail)
        {
            return await _IOnlineTestRepository.UpsertUserDetail(userTestDetail);
        }
    }
}
