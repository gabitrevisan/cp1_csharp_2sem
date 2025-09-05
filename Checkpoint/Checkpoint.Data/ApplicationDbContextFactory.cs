using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Checkpoint.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            // String de conexão usada APENAS para criar as migrations.
            optionsBuilder.UseOracle("User Id=system;Password=99500;Data Source=localhost:1521/FREEPDB1;");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}