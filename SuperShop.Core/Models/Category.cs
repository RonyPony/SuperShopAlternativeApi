using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace superShop_API.Database.Entities;

public class Category
{
    [Required]
    [Column("name", TypeName = "varchar(80)")]
    public string Name { get; set; }



   
}