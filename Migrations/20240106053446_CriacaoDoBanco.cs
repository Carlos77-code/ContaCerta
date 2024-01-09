using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContaCerta.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoDoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Despesas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorDaParcela = table.Column<double>(type: "float", nullable: false),
                    StatusDoMes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormaDePagamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantidadeParcelasPagas = table.Column<int>(type: "int", nullable: false),
                    QuantiadeDeParcelasFaltantes = table.Column<int>(type: "int", nullable: false),
                    QuantidadeTotalDeParcelas = table.Column<int>(type: "int", nullable: false),
                    ValorTotalAPagar = table.Column<double>(type: "float", nullable: false),
                    ValorTotalPago = table.Column<double>(type: "float", nullable: false),
                    DataUltimaAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despesas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Despesas");
        }
    }
}
