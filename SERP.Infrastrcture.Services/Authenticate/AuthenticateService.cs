using SERP.Core.Repository.Authenticate;
using SERP.Core.Services.Authenticate;
using SERP.Core.ViewModelEntities.Authenticate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SERP.Infrastrcture.Services.Authenticate
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly IAuthenticateRepository _authenticateRepository;
        public AuthenticateService(IAuthenticateRepository authenticateRepository)
        {
            _authenticateRepository = authenticateRepository;
        }
        public async  Task<StudentProfileVm> AuthenticateUser(string userName, string password)
        {
            return await _authenticateRepository.AuthenticateUser(userName, password);
        }
    }
}
