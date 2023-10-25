using System.ComponentModel.DataAnnotations;
using MockAPI.Models.Country;

namespace MockAPI.Models.House;

public abstract class BaseHouseDto
{
    [Required]
    public string Name { get; set; }
    [Required]   
    public string Description { get; set; }
    [Required]  
    public string Address { get; set; }
    [Required]  
    public string Postcode { get; set; }
        
    public double? Rating { get; set; }
    [Required]
    [Range(1, int.MaxValue)]
    public int CountryId { get; set; }
    
}