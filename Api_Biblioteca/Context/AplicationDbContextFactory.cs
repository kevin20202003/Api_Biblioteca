using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Api_Biblioteca.Context
{
    public class AplicationDbContextFactory : IDesignTimeDbContextFactory<AplicationDbContext>
    {
        public AplicationDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AplicationDbContext>();
            var connectionString = configuration.GetConnectionString("CadenaSQL");
            optionsBuilder.UseSqlServer(connectionString);

            return new AplicationDbContext(optionsBuilder.Options);
        }
    }
}
