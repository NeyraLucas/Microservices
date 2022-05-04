using System;
using System.Collections.Generic;
using System.Linq;
using PlatformService.Models;

namespace PlatformService.Data
{
    //este es el repository bueno
    public class PlatformRepo : IPlatformRepo
    {

        //dependecy injection
        private readonly AppDbContext _context;

        //Constructor
        public PlatformRepo(AppDbContext context){
            //Database
            _context = context;
        }

        public void CreatePlatform(Platform plat)
        {
            if(plat == null){
                throw new ArgumentNullException(nameof(plat));
            }

            _context.Platforms.Add(plat);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }

        public Platform GetPlatformById(int id)
        {
            return _context.Platforms.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}