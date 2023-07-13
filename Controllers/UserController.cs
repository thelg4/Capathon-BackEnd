using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Capathon.Models;
using Capathon.Services;
using Capathon.Dtos.User;

namespace Capathon
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> GetUsers()
        {
            return Ok(await _userService.GetAllUsers());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> GetUser(int id)
        {
            return Ok(await _userService.GetUserById(id));
        }

        [HttpGet("user-lookup/{username}-{password}")]
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> GetUserFromLogin(string username, string password)
        {
            return Ok(await _userService.GetUserFromLogin(username, password));
        }

        [HttpGet("dependent-lookup/{id}")]
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> GetUserDependents(int id)
        {
            return Ok(await _userService.GetUserDependents(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> AddUser(AddUserDto newUser)
        {
            return Ok(await _userService.AddUser(newUser));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> UpdateUser(UpdateUserDto updatedUser)
        {
            var response = await _userService.UpdateUser(updatedUser);
            if (response.Data is null) {
                return NotFound(response);
            }
            return Ok(response);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> DeleteUser(int id)
        {
            var response = await _userService.DeleteUser(id);
            if (response.Data is null) {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
