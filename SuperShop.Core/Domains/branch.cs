using System.ComponentModel.DataAnnotations;

namespace superShopAlternativeImplementation.CORE.Domains
{
    public class Branch
    {
        /// <summary>
        /// Get or set branch's id.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Get or set branch's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get or set branch's image.
        /// </summary>
        public string ImageUrl{ get; set; }


        /// <summary>
        /// Get or set branch's register date.
        /// </summary>
        public DateTime CreationDate { get; set; }


        /// <summary>
        /// Get or set Branch's description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Get or set Branch's deleted
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
