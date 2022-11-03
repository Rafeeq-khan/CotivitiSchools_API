using API.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.UsersRepo
{
    public interface IUsersRepo
    {
        public Task<List<Users>> GetUserDetails();
    }
}