using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadastro.API.Migrations
{
    public partial class InitiaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Email", "Endereco", "Nome" },
                values: new object[,]
                {
                    { 11, "12345678@gmail.com", "RUA JAMIL JOÃO ZARIF", "JOSE" },
                    { 13, "12345679@gmail.com", "RUA CORONEL JOÃO AFFONSO", "RODINEIA" },
                    { 14, "12345680@gmail.com", "RUA JAMIL JOÃO ZARIF", "DANIELLY" },
                    { 15, "12345681@gmail.com", "RUA JAMIL JOÃO ZARIF", "ROSEVANIA" },
                    { 16, "12345682@gmail.com", "RUA JAMIL JOÃO ZARIF", "JULIANA" },
                    { 22, "12345683@gmail.com", "RUA BENJAMIN CONSTANT", "EVANDRO" },
                    { 28, "12345684@gmail.com", "RUA ARAGÃO", "LUIS ANTONIO" },
                    { 29, "12345685@gmail.com", "AVENIDA ARMANDO ÍTALO SETTI", "LUCIO" },
                    { 30, "12345686@gmail.com", "AVENIDA ARMANDO ÍTALO SETTI", "MIGUEL" },
                    { 31, "12345687@gmail.com", "AVENIDA ARMANDO ÍTALO SETTI", "LUCIANO" },
                    { 32, "12345688@gmail.com", "AVENIDA ARMANDO ÍTALO SETTI", "JOSE RODRIGUES" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
