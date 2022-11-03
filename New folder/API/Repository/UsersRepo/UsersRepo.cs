using API.Server;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.UsersRepo
{
    public class UsersRepo: IUsersRepo
    {
        private readonly rapidContext _context;

        public UsersRepo(rapidContext context)
        {
            _context = context;
        }
        public async Task<List<Users>> GetUserDetails()
        {
            var resultUserData = await _context.Users.ToListAsync();
            return resultUserData;
        }
    }
}
