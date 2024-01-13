using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace The_Piano_house.Data.Migrations
{
    public partial class yaelymmiron : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Providers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Providers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Providers",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Providers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "stockpile",
                table: "MusicaLInstruments",
                newName: "Stockpile");

            migrationBuilder.RenameColumn(
                name: "purchasePrice",
                table: "MusicaLInstruments",
                newName: "PurchasePrice");

            migrationBuilder.RenameColumn(
                name: "providerCode",
                table: "MusicaLInstruments",
                newName: "ProviderCode");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "MusicaLInstruments",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "manufacturer",
                table: "MusicaLInstruments",
                newName: "Manufacturer");

            migrationBuilder.RenameColumn(
                name: "costPrice",
                table: "MusicaLInstruments",
                newName: "CostPrice");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "MusicaLInstruments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Customers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Customers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "lastPurchaseDate",
                table: "Customers",
                newName: "LastPurchaseDate");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Customers",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Customers",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Providers",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Providers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Providers",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Providers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Stockpile",
                table: "MusicaLInstruments",
                newName: "stockpile");

            migrationBuilder.RenameColumn(
                name: "PurchasePrice",
                table: "MusicaLInstruments",
                newName: "purchasePrice");

            migrationBuilder.RenameColumn(
                name: "ProviderCode",
                table: "MusicaLInstruments",
                newName: "providerCode");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MusicaLInstruments",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Manufacturer",
                table: "MusicaLInstruments",
                newName: "manufacturer");

            migrationBuilder.RenameColumn(
                name: "CostPrice",
                table: "MusicaLInstruments",
                newName: "costPrice");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MusicaLInstruments",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Customers",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "LastPurchaseDate",
                table: "Customers",
                newName: "lastPurchaseDate");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Customers",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "id");
        }
    }
}
