using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DotnetBot;

public class DbContextClass : DbContext
{
    protected readonly IConfiguration _configuration;
    public DbSet<User> Users { get; set; }
    public DbSet<Campaign> Campaigns { get; set; }
    public DbContextClass()
    {
        _configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.Development.json", optional: false, reloadOnChange: true)
        .Build();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration["ConnectionStrings:DefaultConnection"]);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
        .HasKey(u => u.Id);

        modelBuilder.Entity<Campaign>()
        .HasKey(u => u.Id);

       
    }



}
