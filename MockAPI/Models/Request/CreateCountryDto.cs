using Microsoft.Build.Framework;

namespace MockAPI.Models;

public class CreateCountryDto
{
    [Required]
    public string Name { get; set; }
    public string ShortName { get; set; }
}