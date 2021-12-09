using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;
//crea roles
namespace CrudHHF.Data
{
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
        await roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
        await roleManager.CreateAsync(new IdentityRole("Organizador"));
        await roleManager.CreateAsync(new IdentityRole("Jugador"));

        }
    }
    
}
