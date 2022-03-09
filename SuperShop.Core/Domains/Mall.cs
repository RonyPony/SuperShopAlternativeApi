using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Core.Domains
{
    public class Mall
    {
        /// <summary>
        /// Get or set branch's id.
        /// </summary>
        [Key]
        public int Id { get; set; }

        public string Name{ get; set; }

        public string ImageUrl { get; set; }


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
