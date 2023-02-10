using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IUserChildService
    {
        Task<List<UserChildDTO>> GetAllAsync();
        Task<UserChildDTO> GetByIdAsync(int id);
        Task<UserChildDTO> AddAsync(UserChildDTO userChildDTO);
        Task<UserChildDTO> UpdateAsync(UserChildDTO userChildDTO);
        Task DeleteAsync(int id);
    }
}
