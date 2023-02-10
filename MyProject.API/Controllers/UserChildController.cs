using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Services.Interfaces;
using MyProject.WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserChildController : ControllerBase
    {
        private readonly IUserChildService _userChildService;

        public UserChildController(IUserChildService userChildService)
        {
            _userChildService = userChildService;
        }

        [HttpGet]
        public async Task<IEnumerable<UserChildDTO>> Get()
        {
            return await _userChildService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<UserChildDTO> Get(int id)
        {
            return await _userChildService.GetByIdAsync(id);
        }
        
        //add
        [HttpPost]
        public async Task<UserChildDTO> Post([FromBody] UserChildModel model)
        {
            UserChildDTO userChildDto= new UserChildDTO
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Tz = model.Tz,
                DateOfBirth = model.DateOfBirth,
                IdParent = model.IdParent
            };
            return await _userChildService.AddAsync(userChildDto);
        }

        //update
        [HttpPut("{id}")]
        public async Task<UserChildDTO> Put(int id, [FromBody] UserChildModel model)
        {
            UserChildDTO userChildDTO = new UserChildDTO()
            {
                ChildId = id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Tz = model.Tz,
                DateOfBirth = model.DateOfBirth,
                IdParent = model.IdParent
            };
            return await _userChildService.UpdateAsync(userChildDTO);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _userChildService.DeleteAsync(id);
        }
    }
}
