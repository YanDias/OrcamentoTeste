using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class BancoLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orcamentos",
                columns: table => new
                {
                    IdOrcamento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeCliente = table.Column<string>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orcamentos", x => x.IdOrcamento);
                });

            migrationBuilder.CreateTable(
                name: "Subcategorias",
                columns: table => new
                {
                    idSub = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategorias", x => x.idSub);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    idProduto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(nullable: true),
                    SubCategoriaidSub = table.Column<int>(nullable: true),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.idProduto);
                    table.ForeignKey(
                        name: "FK_Produtos_Subcategorias_SubCategoriaidSub",
                        column: x => x.SubCategoriaidSub,
                        principalTable: "Subcategorias",
                        principalColumn: "idSub",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProdutosOrcamentos",
                columns: table => new
                {
                    IdProdutoOrcamento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProdutoidProduto = table.Column<int>(nullable: false),
                    OrcamentoIdOrcamento = table.Column<int>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutosOrcamentos", x => x.IdProdutoOrcamento);
                    table.ForeignKey(
                        name: "FK_ProdutosOrcamentos_Orcamentos_OrcamentoIdOrcamento",
                        column: x => x.OrcamentoIdOrcamento,
                        principalTable: "Orcamentos",
                        principalColumn: "IdOrcamento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutosOrcamentos_Produtos_ProdutoidProduto",
                        column: x => x.ProdutoidProduto,
                        principalTable: "Produtos",
                        principalColumn: "idProduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_SubCategoriaidSub",
                table: "Produtos",
                column: "SubCategoriaidSub");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosOrcamentos_OrcamentoIdOrcamento",
                table: "ProdutosOrcamentos",
                column: "OrcamentoIdOrcamento");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosOrcamentos_ProdutoidProduto",
                table: "ProdutosOrcamentos",
                column: "ProdutoidProduto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutosOrcamentos");

            migrationBuilder.DropTable(
                name: "Orcamentos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Subcategorias");
        }
    }
}
