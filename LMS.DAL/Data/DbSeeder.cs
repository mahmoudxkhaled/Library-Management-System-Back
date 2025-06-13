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
                string adminPassword = "Pass@123"; // 🔴 Change in production

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

        public static async Task SeedLibrarianAsync(UserManager<User> userManager)
        {
            try
            {
                // 🔹 Ensure librarian user exists
                string librarianEmail = "Librarian@lms.com";
                string librarianPassword = "123456789";

                var librarianUser = await userManager.FindByEmailAsync(librarianEmail);
                if (librarianUser == null)
                {
                    var newLibrarian = new User
                    {
                        Email = librarianEmail.Trim(),
                        FirstName = "Librarian",
                        LastName = "User",
                        UserName = librarianEmail,
                        PhoneNumber = "000000000000",
                        Role = "Librarian",
                        InsertedTime = DateTime.Now,
                        IsActive = true,
                        EmailConfirmed = true
                    };

                    var createUserResult = await userManager.CreateAsync(newLibrarian, librarianPassword);
                    if (!createUserResult.Succeeded)
                    {
                        throw new Exception($"Failed to create librarian user: {string.Join(", ", createUserResult.Errors.Select(e => e.Description))}");
                    }

                    // ✅ Assign Claims
                    List<Claim> claims = new()
                    {
                        new Claim(ClaimTypes.NameIdentifier, newLibrarian.Id.ToString()),
                        new Claim(ClaimTypes.Email, newLibrarian.Email.ToString()),
                        new Claim(ClaimTypes.Role, newLibrarian.Role.ToString()),
                    };

                    var claimsResult = await userManager.AddClaimsAsync(newLibrarian, claims);
                    if (!claimsResult.Succeeded)
                    {
                        throw new Exception($"Failed to add claims: {string.Join(", ", claimsResult.Errors.Select(e => e.Description))}");
                    }

                    Console.WriteLine("✅ Librarian user created successfully.");
                }
                else
                {
                    Console.WriteLine("ℹ️ Librarian user already exists.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error seeding librarian user: {ex.Message}");
            }
        }

        public static async Task SeedMembersAsync(UserManager<User> userManager)
        {
            try
            {
                var members = new List<(string Email, string FirstName, string LastName)>
                {
                    ("ahmedhamdisaeed@gmail.com", "ahmed", "hamdi saeed"),
                    ("antonius.a.ghaly@gmail.com", "Antonius", "Ghaly"),
                    ("mahmoud.ahmed.pro4@gmail.com", "mahmoud", "ahmed"),
                    ("mahmoudxkhaled@gmail.com", "mahmoud", "khaled")
                };

                string defaultPassword = "Pass@123";

                foreach (var member in members)
                {
                    var existingUser = await userManager.FindByEmailAsync(member.Email);
                    if (existingUser == null)
                    {
                        var newMember = new User
                        {
                            Email = member.Email.Trim(),
                            FirstName = member.FirstName.Trim(),
                            LastName = member.LastName.Trim(),
                            UserName = member.Email,
                            PhoneNumber = "000000000000",
                            Role = "Member",
                            InsertedTime = DateTime.Now,
                            IsActive = true,
                            EmailConfirmed = true
                        };

                        var createUserResult = await userManager.CreateAsync(newMember, defaultPassword);
                        if (!createUserResult.Succeeded)
                        {
                            Console.WriteLine($"Failed to create member {member.Email}: {string.Join(", ", createUserResult.Errors.Select(e => e.Description))}");
                            continue;
                        }

                        // ✅ Assign Claims
                        List<Claim> claims = new()
                        {
                            new Claim(ClaimTypes.NameIdentifier, newMember.Id.ToString()),
                            new Claim(ClaimTypes.Email, newMember.Email.ToString()),
                            new Claim(ClaimTypes.Role, newMember.Role.ToString()),
                        };

                        var claimsResult = await userManager.AddClaimsAsync(newMember, claims);
                        if (!claimsResult.Succeeded)
                        {
                            Console.WriteLine($"Failed to add claims for {member.Email}: {string.Join(", ", claimsResult.Errors.Select(e => e.Description))}");
                            continue;
                        }

                        Console.WriteLine($"✅ Member user {member.Email} created successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"ℹ️ Member user {member.Email} already exists.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error seeding member users: {ex.Message}");
            }
        }

        public static async Task SeedTransactionsAsync(IUnitOfWork unitOfWork)
        {
            try
            {
                // Get all members
                var members = await unitOfWork.UserRepository.GetWhereAsync(u => u.Role == "Member");
                var books = await unitOfWork.BookRepository.GetAllAsync();
                var random = new Random();

                foreach (var member in members)
                {
                    // Random number of transactions between 5-10
                    int transactionCount = random.Next(5, 11);

                    for (int i = 0; i < transactionCount; i++)
                    {
                        // Random book selection
                        var randomBook = books.ElementAt(random.Next(books.Count()));

                        // Random dates
                        var requestDate = DateTime.Now.AddDays(-random.Next(1, 60)); // Random date in the past 60 days
                        var issueDate = requestDate.AddDays(random.Next(1, 3)); // Issue 1-2 days after request
                        var borrowDays = random.Next(7, 15); // Borrow for 7-14 days
                        var dueDate = issueDate.AddDays(borrowDays);

                        // Randomly decide if the book is returned
                        bool isReturned = random.Next(2) == 1; // 50% chance of being returned
                        DateTime? returnDate = null;
                        string status;

                        if (isReturned)
                        {
                            // If returned, return date is between issue date and due date
                            returnDate = issueDate.AddDays(random.Next(1, borrowDays));
                            status = "Returned";
                        }
                        else
                        {
                            // If not returned, check if it's overdue
                            if (DateTime.Now > dueDate)
                            {
                                status = "Overdue";
                            }
                            else
                            {
                                status = "Issued";
                            }
                        }

                        var transaction = new Transaction
                        {
                            UserId = member.Id,
                            BookId = randomBook.Id,
                            RequestDate = requestDate,
                            IssueDate = issueDate,
                            DueDate = dueDate,
                            ReturnDate = returnDate,
                            Status = status,
                            InsertedTime = DateTime.Now,
                            IsActive = true
                        };

                        await unitOfWork.TransactionRepository.AddAsync(transaction);
                    }
                }

                await unitOfWork.SaveChangesAsync();
                Console.WriteLine("✅ Transactions seeded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error seeding transactions: {ex.Message}");
            }
        }
    }
}
