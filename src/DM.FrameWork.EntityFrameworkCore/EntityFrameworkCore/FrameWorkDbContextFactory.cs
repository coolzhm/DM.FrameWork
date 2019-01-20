using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DM.FrameWork.EntityFrameworkCore
{
    public class FrameWorkDbContextFactory : IDesignTimeDbContextFactory<FrameWorkDbContext>
    {
        public FrameWorkDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<FrameWorkDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new FrameWorkDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../DM.FrameWork.Web/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
