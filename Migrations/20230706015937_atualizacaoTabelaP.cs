using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace motogoAPI.Migrations
{
    /// <inheritdoc />
    public partial class atualizacaoTabelaP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Remessa_Pedido_PedidoId",
                table: "Remessa");

            migrationBuilder.DropIndex(
                name: "IX_Remessa_PedidoId",
                table: "Remessa");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Remessa");

            migrationBuilder.AddColumn<int>(
                name: "RemessaId",
                table: "Pedido",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_RemessaId",
                table: "Pedido",
                column: "RemessaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Remessa_RemessaId",
                table: "Pedido",
                column: "RemessaId",
                principalTable: "Remessa",
                principalColumn: "IdRemessa",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Remessa_RemessaId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_RemessaId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "RemessaId",
                table: "Pedido");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Remessa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Remessa_PedidoId",
                table: "Remessa",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Remessa_Pedido_PedidoId",
                table: "Remessa",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
