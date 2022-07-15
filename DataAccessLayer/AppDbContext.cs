using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer;

public class AppDbContext: DbContext
{
    public DbSet<Product> Products { get; set; } = null!;
    private IConfiguration Config { get; }
    public AppDbContext()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
        Config = builder.Build();
    }
 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = Config.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString);
    }
}

// dotnet ef migrations add Init -p DataAccessLayer -s Gateway
// dotnet ef database update -p DataAccessLayer -s Gateway