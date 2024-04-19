using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApiDotnet.Migrations
{
    public partial class PaymentTransactionNewColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BankCode",
                table: "PaymentTransactions",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankCode",
                table: "PaymentTransactions");
        }
    }
}
