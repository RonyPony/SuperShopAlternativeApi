using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Linq.Expressions;
using Newtonsoft.Json;
using superShopAlternativeImplementation.CORE.Domains;

namespace superShop_API.Database.Entities;

[Table("malls")]
public class Mall
{
    [Required]
    [Column("name", TypeName = "varchar(80)")]
    public string Name { get; set; }

    [Required]
    [Column("coordinates")]
    public Coordinates Coordinates { get; set; }

    [Required]
    [Column("imageUrl", TypeName = "text")]
    public string ImageUrl { get; set; }

    public virtual ICollection<Branch>? Branches { get; set; }

}

public struct Coordinates
{
    public Coordinates(double lat, double @long)
    {
        Lat = lat;
        Long = @long;
    }

    public double Lat { get; set; }
    public double Long { get; set; }
}

public class CoordinatesCorverter : ValueConverter<Coordinates, string>
{
    public CoordinatesCorverter() : base(coords => CoordinatesToJson(coords), str => JsonToCoordinates(str))
    {
    }

    public static string CoordinatesToJson(Coordinates value)
    {
        return JsonConvert.SerializeObject(value);
    }

    public static Coordinates JsonToCoordinates(string value)
    {
        return JsonConvert.DeserializeObject<Coordinates>(value);
    }
}