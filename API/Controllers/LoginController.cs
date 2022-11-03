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
    [AllowAnonymous]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _service;

        public LoginController(ILoginService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("username/{userName}/password/{userPassword}")]
        public async Task<IActionResult> ValidateUser([FromRoute] string userName, string userPassword)
        {
            var respone =await _service.ValidateLogin(userName, userPassword);
            return Ok(respone);
        }

        [HttpPost]
        [Route("validate")]
        public async Task<IActionResult> Validation(login user)
        {
            var authRespone = await _service.Validate(user);
            switch (authRespone.Message)
            {
                case "Success":
                    return Ok(authRespone);
                    case "Error":
                    return Unauthorized(authRespone.Message);
                        case "User doesn't exits":
                            return Unauthorized(authRespone.Message);
                default:
                    return BadRequest(authRespone.Message);

            }
        }

        [HttpPost]
        [Route("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authentication(login userCredentials)
        {
            var authResponse = await _service.Authenticate(userCredentials);
            return Ok(authResponse);
        }
    }
}
