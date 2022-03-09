using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using superShopAlternativeImplementation.CORE.Domains;

namespace superShop_API.Database.Entities;


public class Order
{
    [Required]
    [Column("branchId")]
    public Guid BranchId { get; set; }

    [Required]
    [Column("userId")]
    public Guid UserId { get; set; }

    [Required]
    [Column("address", TypeName = "varchar(512)")]
    public string Address { get; set; }

    [Required]
    [Column("total")]
    public double Total { get; set; }

    [Required]
    [Column("completed")]
    public bool Completed { get; set; }

    [ForeignKey("branchId")]
    public Branch Branch { get; set; }

    [ForeignKey("userId")]
    public string User { get; set; }

    public IList<ProductOrder> ProductOrders { get; set; }

    
}