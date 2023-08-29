using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace motogoAPI.Migrations
{
    /// <inheritdoc />
    public partial class atualizacaoTabelaPrecokg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrecoKg",
                table: "Preco",
                newName: "PrecoTempo");

            migrationBuilder.AddColumn<double>(
                name: "Preco12Kg",
                table: "Preco",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Preco1Kg",
                table: "Preco",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Preco3Kg",
                table: "Preco",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Preco8Kg",
                table: "Preco",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preco12Kg",
                table: "Preco");

            migrationBuilder.DropColumn(
                name: "Preco1Kg",
                table: "Preco");

            migrationBuilder.DropColumn(
                name: "Preco3Kg",
                table: "Preco");

            migrationBuilder.DropColumn(
                name: "Preco8Kg",
                table: "Preco");

            migrationBuilder.RenameColumn(
                name: "PrecoTempo",
                table: "Preco",
                newName: "PrecoKg");
        }
    }
}
