using Microsoft.EntityFrameworkCore;
using PaymentApiDotnet.Models;
using PaymentApiDotnet.Repository.Config;

namespace PaymentApiDotnet.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
      

        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }
        public DbSet<Bin> Bins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BinConfig());
        }
    }
}
