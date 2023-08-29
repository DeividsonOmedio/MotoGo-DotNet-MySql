using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace motogoAPI.Migrations
{
    /// <inheritdoc />
    public partial class atualizacaoTabelaPed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Entregador_EntregadoresId",
                table: "Pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Precos",
                table: "Precos");

            migrationBuilder.RenameTable(
                name: "Precos",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "precoDia",
                table: "Preco",
                newName: "PrecoDia");

            migrationBuilder.AlterColumn<int>(
                name: "EntregadoresId",
                table: "Pedido",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Preco",
                table: "Preco",
                column: "IdPreco");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Entregador_EntregadoresId",
                table: "Pedido",
                column: "EntregadoresId",
                principalTable: "Entregador",
                principalColumn: "IdEntregador");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Entregador_EntregadoresId",
                table: "Pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Preco",
                table: "Preco");

            migrationBuilder.RenameTable(
                name: "Preco",
                newName: "Precos");

            migrationBuilder.RenameColumn(
                name: "PrecoDia",
                table: "Precos",
                newName: "precoDia");

            migrationBuilder.AlterColumn<int>(
                name: "EntregadoresId",
                table: "Pedido",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Precos",
                table: "Precos",
                column: "IdPreco");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Entregador_EntregadoresId",
                table: "Pedido",
                column: "EntregadoresId",
                principalTable: "Entregador",
                principalColumn: "IdEntregador",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
