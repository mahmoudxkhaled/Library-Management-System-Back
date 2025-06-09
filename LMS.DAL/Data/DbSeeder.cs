using LMS.DAL.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace LMS.DAL.Data
{
    public static class DbSeeder
    {
        public static async Task SeedAdminAsync(UserManager<User> userManager)
        {
            try
            {
                // 🔹 Ensure admin user exists
                string adminEmail = "admin@lms.com";
                string adminPassword = "Admin@123"; // 🔴 Change in production

                var adminUser = await userManager.FindByEmailAsync(adminEmail);
                if (adminUser == null)
                {
                    var newAdmin = new User
                    {
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
