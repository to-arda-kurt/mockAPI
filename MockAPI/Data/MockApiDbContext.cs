using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MockAPI.Data.Configurations;

namespace MockAPI.Data;

public class MockApiDbContext : IdentityDbContext<ApiUser>
{
    public MockApiDbContext(DbContextOptions options) : base(options)
    { }
    
    public DbSet<House> Houses { get; set; }
    public DbSet<Country> Countries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
        modelBuilder.ApplyConfiguration(new CountryConfiguration());
        modelBuilder.ApplyConfiguration(new HouseConfiguration());
    }
}