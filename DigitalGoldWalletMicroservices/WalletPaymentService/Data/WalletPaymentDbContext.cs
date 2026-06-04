using Microsoft.EntityFrameworkCore;
using WalletPaymentService.Models;

namespace WalletPaymentService.Data
{
    public class WalletPaymentDbContext : DbContext
    {
        public WalletPaymentDbContext(DbContextOptions<WalletPaymentDbContext> options)
            : base(options)
        {
        }

        public DbSet<VirtualGoldHolding> VirtualGoldHoldings { get; set; }
        public DbSet<Payment> Payments { get; set; }
    
    }
}
