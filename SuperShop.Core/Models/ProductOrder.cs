using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace superShop_API.Database.Entities;

public class ProductOrder 
{
    [Required]
    [Column("productId")]
    public Guid ProductId { get; set; }

    public Product Product { get; set; }

    [Required]
    [Column("orderId")]
    public Guid OrderId { get; set; }

    public Order Order { get; set; }
}