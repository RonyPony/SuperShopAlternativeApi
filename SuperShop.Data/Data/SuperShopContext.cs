using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Polidom.Core.Domains;
using SuperShop.Core.Domains;
using SuperShop.Data.Configuration;
using SuperShop.Data.Data.identity;
using superShopAlternativeImplementation.CORE.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.Entity;
using System.Threading.Tasks;

namespace SuperShop.Data.Data
{
    public class SuperShopContext : DbContext//IdentityDbContext<Account>
    {
        public SuperShopContext(DbContextOptions<SuperShopContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            //builder.ApplyConfiguration(new RoleConfiguration());
            base.OnModelCreating(builder);
            builder.Entity<Mall>().HasQueryFilter(x => x.IsDeleted == false);
        }


        #region DbSet

        /// <summary>
        /// Get or set context's reports
        /// </summary>
        public DbSet<Branch> branches { get; set; }

        /// <summary>
        /// Get or set context's report mapping.
        /// </summary>
        public DbSet<AssignBranchMapping> ReportMappings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnections");
            optionsBuilder.UseSqlServer(connectionString);
        }

        /// <summary>
        /// Get or set context's photo
        /// </summary>
        public DbSet<Mall> Malls{ get; set; }

        #endregion
    }
}
