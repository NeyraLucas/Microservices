using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt):base(opt)
        {
             
        }

        //Se tiene que agregar al startup.cs en ConfigureServices
        public DbSet<Platform> Platforms { get; set;}
    }
}