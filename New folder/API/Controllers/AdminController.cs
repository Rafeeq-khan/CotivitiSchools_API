using API.Models;
using API.Services;
using API.Server;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AdminController : ControllerBase
    {
        private readonly IUpdateContentService _service;

        public AdminController(IUpdateContentService service)
        {
            _service = service;
        }
        [HttpPut]
        [Route("update")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateContent([FromQuery]int id, Update contents)
        {
                var status = await _service.UpdateContents(id,contents);
                return Ok(status);
            
             
        }

        // var status =await _service.UpdateContents(id,user,contents);
        //return Ok(status);
        //var res = id.ToString() + user + contents;

    }
}
