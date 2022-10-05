using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIGNA.Migrations
{
    public partial class DBMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PESSOA",
                columns: table => new
                {
                    PESSOA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NOME_FANTASIA = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CNPJ_CPF = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PESSOA", x => x.PESSOA_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "PESSOA",
                columns: new[] { "PESSOA_ID", "CNPJ_CPF", "NOME_FANTASIA" },
                values: new object[,]
                {
                    { 1, "694.678.770-66", "Coca Coallers" },
                    { 2, "265.752.130-49", "Nika" },
                    { 3, "102.584.620-60", "DJDonalds" },
                    { 4, "984.814.520-68", "Soda King" },
                    { 5, "563.968.300-78", "Pólen Station" },
                    { 6, "720.070.510-10", "Beto Carreto" },
                    { 7, "834.227.360-18", "Mercadão" },
                    { 8, "425.927.670-02", "Suprema" },
                    { 9, "878.451.000-56", "Grapes" },
                    { 10, "467.754.590-17", "Soni Edison" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PESSOA");
        }
    }
}
