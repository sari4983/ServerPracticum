using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class UserChildService:IUserChildService
    {
        private readonly IUserChildRepository _userChildRepository;
        private readonly IMapper _mapper;

        public UserChildService(IUserChildRepository userChildRepository, IMapper mapper)
        {
            _userChildRepository = userChildRepository;
            _mapper = mapper;
        }

        public async Task<UserChildDTO> AddAsync(UserChildDTO userChildDTO)
        {
            return _mapper.Map<UserChildDTO>(await _userChildRepository.AddAsync(_mapper.Map<UserChild>(userChildDTO)));
        }

        public async Task DeleteAsync(int id)
        {
            await _userChildRepository.DeleteAsync(id);
        }

        public async Task<List<UserChildDTO>> GetAllAsync()
        {
            return _mapper.Map<List<UserChildDTO>>(await _userChildRepository.GetAllAsync());
        }

        public async Task<UserChildDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<UserChildDTO>(await _userChildRepository.GetByIdAsync(id));
        }

        public async Task<UserChildDTO> UpdateAsync(UserChildDTO userChildDTO)
        {
            return _mapper.Map<UserChildDTO>(await _userChildRepository.UpdateAsync
                (_mapper.Map<UserChild>(userChildDTO)));
        }
    }
}
