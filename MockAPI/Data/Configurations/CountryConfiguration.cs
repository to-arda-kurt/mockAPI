using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MockAPI.Data.Configurations;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.HasData(
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
            }

        );
    }
}