using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Services.Interfaces;
using MyProject.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IEnumerable<UserDTO>> Get()
        {
            return await _userService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<UserDTO> Get(int id)
        {
            return await _userService.GetByIdAsync(id);
        }

        [HttpGet("tz/{tz}")]
        public async Task<UserDTO> GetByTz(string tz)
        {
            return await _userService.GetByTzAsync(tz);
        }

        //add
        [HttpPost]
        public async Task<UserDTO> Post([FromBody] UserModel model)
        {
            UserDTO userDTO = new UserDTO
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Tz = model.Tz,
                DateOfBirth = model.DateOfBirth,
                Gender = (eGenderUserDTO)model.Gender,
                HMO = model.HMO,
            };
            return await _userService.AddAsync(userDTO);
        }

        //update
        [HttpPut("{id}")]
        public async Task<UserDTO> Put(int id, [FromBody] UserModel model)
        {
            UserDTO userDTO = new UserDTO()
            {
                Id= id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Tz = model.Tz,
                DateOfBirth = model.DateOfBirth,
                Gender = (eGenderUserDTO)model.Gender,
                HMO = model.HMO,
            };
            return await _userService.UpdateAsync(userDTO);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _userService.DeleteAsync(id);
        }
    }
}
