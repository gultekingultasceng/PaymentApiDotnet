using Microsoft.EntityFrameworkCore;
using PaymentApiDotnet.Models;

namespace PaymentApiDotnet.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
      

        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }
        public DbSet<Bin> Bins { get; set; }
    }
}
