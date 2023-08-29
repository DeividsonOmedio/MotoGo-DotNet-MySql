using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace motogoAPI.Migrations
{
    /// <inheritdoc />
    public partial class tableentregadores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndereçoEntregadores",
                table: "Entregador");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EndereçoEntregadores",
                table: "Entregador",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
