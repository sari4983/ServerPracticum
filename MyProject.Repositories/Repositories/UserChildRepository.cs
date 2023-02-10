using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class UserChildRepository : IUserChildRepository
    {
        private readonly IContext _context;

        public UserChildRepository(IContext context)
        {
            _context = context;
        }

        public async Task<UserChild> AddAsync(UserChild child)
        {
            var childToAdd = _context.children.Add(new UserChild
            {
                ChildId = child.ChildId,
                FirstName = child.FirstName,
                LastName = child.LastName,
                Tz = child.Tz,
                DateOfBirth = child.DateOfBirth,
                IdParent = child.IdParent,
            });
            await _context.SaveChangesAsync();
            return childToAdd.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.children.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<UserChild>> GetAllAsync()
        {
            return await _context.children.Include(p => p.Parent).ToListAsync();
        }

        public async Task<UserChild> GetByIdAsync(int id)
        {
            return await _context.children.Include(p => p.Parent).FirstOrDefaultAsync(p => p.ChildId == id);
        }

        public async Task<UserChild> UpdateAsync(UserChild waiting)
        {
            var childToUpdate = _context.children.Update(waiting);
            await _context.SaveChangesAsync();
            return childToUpdate.Entity;
        }
    }
}
