using SuperShop.Core.Domains;
using superShop_API.Database.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace superShopAlternativeImplementation.CORE.Models
{
    public sealed class BranchToRegister
    {

        /// <summary>
        /// Get or set branch's user id
        /// </summary>
        public string BranchID { get; set; }


        /// <summary>
        /// Get or set branch's description
        /// </summary>
        public string Description { get; set; }

        [Required]
        [Column("name", TypeName = "varchar(80)")]
        public string Name { get; set; }

        [Column("categoryId", TypeName = "varchar(80)")]
        public string CategoryId { get; set; }


        [ForeignKey("mallId")]
        public SuperShop.Core.Domains.Mall? Mall { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
