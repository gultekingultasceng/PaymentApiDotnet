using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentApiDotnet.Entities.Models;

namespace PaymentApiDotnet.Repositories.EFCore.Config
{
    public class BinConfig : IEntityTypeConfiguration<Bin>
    {
        public void Configure(EntityTypeBuilder<Bin> builder)
        {
            var lines = File.ReadAllLines(@"Files/bincsv.csv");
            List<Bin> bins = new List<Bin>();
            for (int i = 0; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');
                Bin bin = new Bin
                {
                    Id = i + 1,
                    BinNumber = int.Parse(values[0]),
                    BankCode = int.Parse(values[1]),
                    BankName = values[2],
                    CardType = values[3],
                    CardSubType = values[4],
                    Virtual = "no",
                    Prepaid = "no"
                };
                bins.Add(bin);
            }
            foreach (var line in lines)
            {

            }
            builder.HasData(bins
                );
        }
    }
}
