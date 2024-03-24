using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BairroConnectAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_LOGINS",
                columns: table => new
                {
                    idPessoa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoConta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_LOGINS", x => x.idPessoa);
                });

            migrationBuilder.InsertData(
                table: "TB_LOGINS",
                columns: new[] { "idPessoa", "email", "nome", "sobrenome", "tipoConta" },
                values: new object[,]
                {
                    { 1, "carlos.e.789999@gmail.com", "Carlos", "Silva", 1 },
                    { 2, "daniel.silva@gmail.com", "Daniel", "Silva", 1 },
                    { 3, "teste.e.@gmail.com", "teste", "teste", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_LOGINS");
        }
    }
}
