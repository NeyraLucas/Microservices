using System.Collections.Generic;
using PlatformService.Models;

namespace PlatformService.Data
{
    ///Este es el repositorio lo primero que se tiene que hacer es crear esta clase
    public interface IPlatformRepo{
        bool SaveChanges();

        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform plat);
    }
}