using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Task.DAL.Entities;

namespace Task.DAL.EF
{
    class RoleInitializer   
    {
        public static async Task InitializeAsync(UserManager<UserEntity> userManager, RoleManager<IdentityRole> roleManager)
        {
            string adminEmail = "admin@gmail.com";
            string password = "admin@gmail.com";
            string login = "admin";
            string user1_p = "jager@gmail.com";
            string user2_p = "user@gmail.com";
            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("user"));
            }
            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                UserEntity admin = new UserEntity { Login = login };
                UserEntity user1 = new UserEntity { Login = "jager" };
                UserEntity user2 = new UserEntity { Login = "user" };
                IdentityResult result = await userManager.CreateAsync(admin, password);
                await userManager.CreateAsync(user1, user1_p);
                await userManager.CreateAsync(user2, user2_p);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                    await userManager.AddToRoleAsync(user1, "user");
                    await userManager.AddToRoleAsync(user2, "user");
                }
            }
        }
    }
}
