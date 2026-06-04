using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using VendorGoldService.Models;

namespace VendorGoldService.Data
{
    public class VendorGoldDbContext : DbContext
    {
        public VendorGoldDbContext(DbContextOptions<VendorGoldDbContext> options)
            : base(options)
        {
        }

        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<VendorBranch> VendorBranches { get; set; }
    }
}
