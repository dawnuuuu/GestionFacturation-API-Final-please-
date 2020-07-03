using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionFacturation.Data.Models;
using GestionFacturation.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionFacturation.Controllers
{
    
        [Authorize]
        [ApiController]
        [Route("api/[controller]")]
        public class UsersController : ControllerBase
        {
            private IUserService _userService;

            public UsersController(IUserService userService)
            {
                _userService = userService;
            }

            [AllowAnonymous]
            [HttpPost("authenticate")]
            public IActionResult Authenticate([FromBody]AuthenticateRequest model)
            {
                var response = _userService.Authenticate(model);

                if (response == null)
                    return BadRequest(new { message = "Username or password is incorrect" });

                return Ok(response);
            }

            [HttpGet]
            public IActionResult GetAll()
            {
                var users = _userService.GetAll();
                return Ok(users);
            }
        }
    }