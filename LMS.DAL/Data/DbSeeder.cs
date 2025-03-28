using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace LMS.DAL.Data
{
    public static class DbSeeder
    {
        public static async Task SeedRolesAndAdminAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            try
            {


                string[] roleNames = { "Admin", "Librarian", "Member" };

                // 🔹 Ensure roles exist
                foreach (var roleName in roleNames)
                {
                    if (!await roleManager.RoleExistsAsync(roleName))
                    {
                        await roleManager.CreateAsync(new IdentityRole(roleName));
                    }
                }

                // 🔹 Ensure admin user exists
                string adminEmail = "admin@lms.com";
                string adminPassword = "Admin@123"; // 🔴 Change in production

                var adminUser = await userManager.FindByEmailAsync(adminEmail);
                if (adminUser == null)
                {

                    var newAdmin = new User
                    {
                        Id = Guid.NewGuid().ToString(),
                        Email = adminEmail.Trim(),
                        FirstName = "Admin",
                        LastName = "User",
                        UserName = adminEmail,
                        PhoneNumber = "000000000000",
                        Role = "Admin",
                        InsertedTime = DateTime.Now,
                        IsActive = true,
                        EmailConfirmed = true
                    };

                    var createUserResult = await userManager.CreateAsync(newAdmin, adminPassword);
                    if (!createUserResult.Succeeded)
                    {
                        throw new Exception($"Failed to create admin user: {string.Join(", ", createUserResult.Errors.Select(e => e.Description))}");
                    }

                    // ✅ Assign Admin role
                    await userManager.AddToRoleAsync(newAdmin, "Admin");

                    // ✅ Assign Claims
                    List<Claim> claims = new()
                    {
                        new Claim(ClaimTypes.NameIdentifier, newAdmin.Id.ToString()),
                        new Claim(ClaimTypes.Email, newAdmin.Email.ToString()),
                        new Claim(ClaimTypes.Role, newAdmin.Role.ToString()),
                    };

                    var claimsResult = await userManager.AddClaimsAsync(newAdmin, claims);
                    if (!claimsResult.Succeeded)
                    {
                        throw new Exception($"Failed to add claims: {string.Join(", ", claimsResult.Errors.Select(e => e.Description))}");
                    }

                    Console.WriteLine("✅ Admin user created successfully.");

                }
                else
                {
                    Console.WriteLine("ℹ️ Admin user already exists.");
                }



            }
            catch (Exception ex)


            {
                Console.WriteLine($"❌ Error seeding admin user: {ex.Message}");
            }

        }
    }
}
