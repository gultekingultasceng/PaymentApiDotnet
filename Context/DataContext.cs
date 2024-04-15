using Microsoft.EntityFrameworkCore;
using PaymentApiDotnet.Models;

namespace PaymentApiDotnet.Context
{
    public class DataContext : DbContext
    {

       // protected readonly IConfiguration Configuration;

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            //Configuration = configuration;
        }
      

        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }
    }
}
