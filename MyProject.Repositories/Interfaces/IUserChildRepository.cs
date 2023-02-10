using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IUserChildRepository
    {
        Task <List<UserChild>> GetAllAsync(); 
        Task<UserChild> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<UserChild> UpdateAsync(UserChild child);
        Task<UserChild> AddAsync(UserChild child);
    }
}
