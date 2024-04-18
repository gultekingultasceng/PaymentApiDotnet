using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentApiDotnet.Models;

namespace PaymentApiDotnet.Repository.Config
{
    public class BinConfig : IEntityTypeConfiguration<Bin>
    {
        public void Configure(EntityTypeBuilder<Bin> builder)
        {
            var lines = System.IO.File.ReadAllLines(@"Files/bincsv.csv");
            List<Bin> bins = new List<Bin>();
            for (int i = 0;i < lines.Length;i++)
            {
                var values = lines[i].Split(',');
                Bin bin = new Bin
                {
                    Id = (i + 1),
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
