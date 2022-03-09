using Microsoft.AspNetCore.Identity;
using SuperShop.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Data.Data.identity
{
    public class Account: IdentityUser
    {
        /// <summary>
        /// Get or set user's name
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Get or set account's role
        /// </summary>
        public UserRoleType Role { get; set; }

        /// <summary>
        /// Get or set account's registered date.
        /// </summary>
        public DateTime RegisterDate { get; set; }

    }
}
