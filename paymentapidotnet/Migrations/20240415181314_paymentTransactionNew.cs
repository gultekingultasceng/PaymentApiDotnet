using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApiDotnet.Migrations
{
    public partial class paymentTransactionNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaymentType",
                table: "PaymentTransactions",
                newName: "CardType");

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "PaymentTransactions",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankName",
                table: "PaymentTransactions");

            migrationBuilder.RenameColumn(
                name: "CardType",
                table: "PaymentTransactions",
                newName: "PaymentType");
        }
    }
}
