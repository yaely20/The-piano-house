using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace The_Piano_house.Data.Migrations
{
    public partial class yaely100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProviderId",
                table: "MusicaLInstruments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MusicaLInstruments_ProviderId",
                table: "MusicaLInstruments",
                column: "ProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_MusicaLInstruments_Providers_ProviderId",
                table: "MusicaLInstruments",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MusicaLInstruments_Providers_ProviderId",
                table: "MusicaLInstruments");

            migrationBuilder.DropIndex(
                name: "IX_MusicaLInstruments_ProviderId",
                table: "MusicaLInstruments");

            migrationBuilder.DropColumn(
                name: "ProviderId",
                table: "MusicaLInstruments");
        }
    }
}
