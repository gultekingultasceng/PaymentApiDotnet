﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApiDotnet.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var lines = System.IO.File.ReadAllLines(@"Files/bincsv.csv");
            foreach (var line in lines)
            {
                var values = line.Split(',');

                migrationBuilder.InsertData(
                    table: "Bins",
                    columns: new[] { "BinNumber","BankCode", "BankName", "CardType", "CardSubType", "Virtual", "Prepaid" },
                    values: new object[] {
            values[0], // 
            values[1], // 
            values[2], // 
            values[3], // 
            values[4], // 
            "No",     // 
            "No"      // 
                    });
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
