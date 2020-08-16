using SERP.Core.ViewModelEntities.Authenticate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SERP.Core.Repository.Authenticate
{
    public interface  IAuthenticateRepository
    {
        Task<StudentProfileVm> AuthenticateUser(string userName, string password);
    }
}
