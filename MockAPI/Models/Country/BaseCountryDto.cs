using System.ComponentModel.DataAnnotations;

namespace MockAPI.Models.Country;

public abstract class BaseCountryDto
{
    [Required]
    public string Name { get; set; }

    public string ShortName { get; set; }
}