using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public interface ILoginService
    {
        public Task<User> ValidateLogin(string uName, string password);

        public Task<User> Validate(login user);
        public Task<string> Authenticate(login credentials);
    }
}
