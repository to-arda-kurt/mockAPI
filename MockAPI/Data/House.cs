using System.ComponentModel.DataAnnotations.Schema;

namespace MockAPI.Data;

public class House
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public string Description { get; set; }
    public string Address { get; set; }
    
    public string Postcode { get; set; }
    public double Rating { get; set; }

    [ForeignKey(nameof(CountryId))]
    public int CountryId { get; set; }
    
    public Country Country { get; set; }
    
}