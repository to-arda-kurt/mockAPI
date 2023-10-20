using Microsoft.EntityFrameworkCore;

namespace MockAPI.Data;

public class MockApiDbContext : DbContext
{
    public MockApiDbContext(DbContextOptions options) : base(options)
    { }
    
    public DbSet<House> Houses { get; set; }
    public DbSet<Country> Countries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Country>().HasData(
            new Country
            {
                Id = 1,
                Name = "United Kingdom",
                ShortName = "UK"

            }, 
            new Country
            {
                Id = 2,
                Name = "Wales",
                ShortName = "WAL"
            },
            new Country
            {
                Id = 3,
                Name = "Scotland",
                ShortName = "SCO"
            },
            new Country
            {
                Id = 4,
                Name = "England",
                ShortName = "ENG"
            });

        modelBuilder.Entity<House>().HasData(
            new House
            {
                Id = 1,
                Name = "3 Bedroom Detached House",
                Description = "From the outside this house looks gorgeous. It has been built with wheat colored bricks and has sandstone decorations. Small, octagon windows let in plenty of light and have been added to the house in a very asymmetric way.",
                Address = "Chelmsford, Essex",
                Postcode = "CM2 1AA",
                CountryId = 4,
                Rating = 4.5
            },
            new House
            {
                Id = 2,
                Name = "3 Bedroom State House",
                Description = "The house is equipped with an average kitchen and one large bathroom, it also has a comfortable living room, two bedrooms, a large dining room, a bar and a snug basement.",
                Address = "London Road, Cardiff",
                Postcode = "CA2 9KK",
                CountryId = 2,
                Rating = 4.2
            },
            new House
            {
                Id = 3 ,
                Name = "2 Bedroom City Flat",
                Description = "The roof is high and v-shaped and is covered with wood shingles. One large chimney sits at the side of the house. A few round, small windows let in enough light to the rooms below the roof.\nThe house itself is surrounded by paved ground, with various party spots, like a fancy barbeque and a firepit.\n",
                Address = "Old Town, Edinburgh",
                Postcode = "ED3 2HQ",
                CountryId = 3,
                Rating = 4.9
            });
    }
}