using example_project_domain;
using Microsoft.EntityFrameworkCore;

namespace example_project_data
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=dotnet_example;User ID=sa;Password=SqlExpress123;");
        }

        public DbSet<Product> Products { get; set; }
    }
}