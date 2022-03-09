using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Data.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
           builder.HasData(
              builder.HasData
                (
                   new IdentityRole
                   {
                       Id = "1",
                       Name = "ADMIN",
                       NormalizedName = "Admin",
                       ConcurrencyStamp = string.Empty
                   },
                   new IdentityRole
                   {
                       Id = "2",
                       Name = "AUTHORITY",
                       NormalizedName = "Authority",
                       ConcurrencyStamp = string.Empty
                   }
                ));
        }
    }
}
