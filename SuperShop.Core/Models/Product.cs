using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using superShopAlternativeImplementation.CORE.Domains;

namespace superShop_API.Database.Entities;



[Table("products")]
public class Product
{
    [Required]
    [Column("name", TypeName = "varchar(80)")]
    public string Name { get; set; }

    [Required]
    [Column("code", TypeName = "varchar(32)")]
    public string Code { get; set; }

    [Required]
    [Column("description", TypeName = "varchar(256)")]
    public string Description { get; set; }

    [Required]
    [Column("price", TypeName = "money")]
    public decimal Price { get; set; }

    [Required]
    [Column("stock", TypeName = "integer")]
    public int Stock { get; set; }

    [Required]
    [Column("imageUrl", TypeName = "text")]
    public string ImageUrl { get; set; }

    [Required]
    [Column("branchId")]
    public Guid BranchId { get; set; }

    [Required]
    [Column("categoryId")]
    public Guid CategoryId { get; set; }

    [ForeignKey("branchId")]
    public Branch? Branch { get; set; }

    [ForeignKey("categoryId")]
    public Category? Category { get; set; }

    public IList<ProductOrder>? ProductOrders { get; set; }

    
}