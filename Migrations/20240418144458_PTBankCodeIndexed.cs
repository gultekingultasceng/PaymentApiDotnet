using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApiDotnet.Migrations
{
    public partial class PTBankCodeIndexed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PaymentTransactions_BankCode",
                table: "PaymentTransactions",
                column: "BankCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PaymentTransactions_BankCode",
                table: "PaymentTransactions");
        }
    }
}
