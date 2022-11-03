using API.Models;
using API.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class RegisterServices: IRegisterServices
    {
        private readonly rapidContext context;

        public RegisterServices(rapidContext _context)
        { 
            context = _context;
        }
        public async Task<string> RegisterUser(RegisterForm userForm)
        {
            try
            {
                await context.Users.AddAsync(new Users
                {
                    FirstName = (userForm.Firstname).ToLower(),
                    LastName = (userForm.Lastname).ToLower(),
                    Email = (userForm.Email).ToLower(),
                    Password = userForm.Password,
                    CreatedBy = userForm.Firstname.ToLower(),
                    CreatedDate = DateTime.Now,
                    RoleId = 000
                });
            }
            catch(Exception e)
            {
                throw (e);
            }

            
            var status= await context.SaveChangesAsync();
            if(status != 0){
                return "Success";
            }
            return "Failed";
        }
    }
}
