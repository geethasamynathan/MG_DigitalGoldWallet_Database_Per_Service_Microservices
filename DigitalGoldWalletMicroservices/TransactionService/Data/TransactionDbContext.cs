using Microsoft.EntityFrameworkCore;
using TransactionService.Models;

namespace TransactionService.Data
{
    public class TransactionDbContext: DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options)
            : base(options)
        {
        }

        public DbSet<PhysicalGoldTransaction> PhysicalGoldTransactions { get; set; }
        public DbSet<TransactionHistory> TransactionHistories { get; set; }
    }
}
