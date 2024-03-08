using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "Tb_Produto");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Tb_Cliente");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Tb_Cliente",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Tb_Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_Produto",
                table: "Tb_Produto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_Cliente",
                table: "Tb_Cliente",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_Produto",
                table: "Tb_Produto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_Cliente",
                table: "Tb_Cliente");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Tb_Cliente");

            migrationBuilder.RenameTable(
                name: "Tb_Produto",
                newName: "Produtos");

            migrationBuilder.RenameTable(
                name: "Tb_Cliente",
                newName: "Clientes");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");
        }
    }
}
