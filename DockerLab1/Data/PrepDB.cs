using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace DockerLab1.Data
{
    public static class PrepDB
    {
        public static void PrepPop(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<ApplicationDbContext>());
            }
        }

        public static void SeedData(ApplicationDbContext context)
        {
            System.Console.WriteLine("Applying Migration");
            context.Database.Migrate();
        }

        
    }
}
