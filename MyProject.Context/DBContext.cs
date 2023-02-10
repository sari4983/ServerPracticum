using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace MyProject.Context
{
    public class DBContext:DbContext,IContext
    {        
        public DbSet<User> Users { get ; set ; }

        public DbSet<UserChild> children { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyProject_Sari_Database_last;Trusted_Connection=True;");
        }
    }
}
