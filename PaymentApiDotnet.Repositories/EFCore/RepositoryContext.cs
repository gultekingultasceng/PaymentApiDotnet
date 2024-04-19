using Microsoft.EntityFrameworkCore;
using PaymentApiDotnet.Entities.Models;
using PaymentApiDotnet.Repositories.EFCore.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApiDotnet.Repositories.EFCore
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
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
