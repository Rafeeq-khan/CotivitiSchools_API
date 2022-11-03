
using API.Repository.UsersRepo;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Server;
using Microsoft.Extensions.Configuration;

namespace API.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUsersRepo _usersRepo;
        private readonly IConfiguration _config;

        public LoginService(IUsersRepo userRepo,IConfiguration config)
        {
            _usersRepo = userRepo;
            _config = config;
        }

        public async Task<User> ValidateLogin(string uName, string password)
        {
            var response = new User();
            var userData = await _usersRepo.GetUserDetails();
            foreach(Users item in userData)
            {
                if (item.Email == uName)
                {
                    if (item.Password == password)
                    {
                        response.FirstName = item.FirstName;
                        response.LastName = item.LastName;
                        response.UserId = item.UserId;
                        response.Message = "Success";
                      
                    }
                    else
                    {
                        response.Message = "Error";
                    }
                }
                else
                {
                    response.Message = "User doesn't exits";
                }
            }

            return response;
        }

        public async Task<User> Validate(login user)
        {
            var valResponse = new User();
            var userAvilable = await _usersRepo.GetUserDetails();
            foreach (Users item in userAvilable)
            {
                if (item.Email == user.Email)
                {
                    if (item.Password == user.Password)
                    {
                        valResponse.FirstName = item.FirstName;
                        valResponse.LastName = item.LastName;
                        valResponse.UserId = item.UserId;
                        valResponse.Message = "Success";

                    }
                    else
                    {
                        valResponse.Message = "Error";
                    }
                }
                else
                {
                    valResponse.Message = "User doesn't exits";
                }
            }

            return valResponse;
        }

        public async Task<string> Authenticate(login credentials)
        {
            string resp="";
            var usersAvailable = await _usersRepo.GetUserDetails();
            foreach(Users user in usersAvailable)
            {
                if (user.Email == credentials.Email)
                {
                    if (user.Password == credentials.Password)
                    {
                        resp = new JwtService(_config).GenerateToken(new User()
                        {
                            UserId = user.UserId,
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            Message = "Sucess",
                            RoleId = user.RoleId.ToString()
                        });
                        break;
                    }
                    else
                    {
                        resp= "Error";
                    }
                }
                else resp= "User doesnt exist";
            }

            return resp;
        }
    }
}
