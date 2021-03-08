using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadastro.API.Migrations
{
    public partial class CreateProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetPessoaById]
                    @ID int
                AS
                BEGIN
                    SET NOCOUNT ON;
                    select * from Pessoas where Id = @ID
                END";

            migrationBuilder.Sql(sp);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
