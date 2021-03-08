using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadastro.API.Migrations
{
    public partial class CreateGetAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetPessoas]
                AS
                BEGIN
                    SET NOCOUNT ON;
                    select * from Pessoas
                END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
