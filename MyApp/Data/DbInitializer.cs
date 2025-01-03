using MyApp.Models;

namespace MyApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.Add(new User
                {
                    Name = "Test User",
                    Email = "testuser@example.com",
                    CreatedAt = DateTime.UtcNow
                });
                context.SaveChanges();
            }
        }
    }
}
