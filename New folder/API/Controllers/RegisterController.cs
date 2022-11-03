using API.Models;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IRegisterServices _regService;

        public RegisterController(IRegisterServices regService)
        {
            _regService = regService;
        }
        [HttpPost]
        [Route("adduser")]
        [AllowAnonymous]
        public async Task<IActionResult> AddUser(RegisterForm newUser)
        {
            var status = await _regService.RegisterUser(newUser);
            return Ok(status);
        }
        [HttpPost]
        [Route("add")]
        [AllowAnonymous]
        public async Task<IActionResult> Add()
        {
            return Ok("SUCCESS");
        }

    }
}
