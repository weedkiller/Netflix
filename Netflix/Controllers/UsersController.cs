﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netflix.Domain.Models.UserContext;
using Netflix.Services;

namespace Netflix.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        // GET: api/<controller>
        [HttpGet]
        [ProducesResponseType(typeof(UserProfile), 200)]
        public async Task<User> Login(Guid id)
        {
            return await _usersService.GetUserById(id);
        }

        // POST: api/<controller>
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<bool> Register(UserRegister user)
        {
            return await _usersService.AddUser(user);
        }

        // Put: api/<controller>
        [HttpPut]
        public async Task<bool> UpdateUser(User user)
        {
            return await _usersService.UpdateUser(user);
        }
    }

}