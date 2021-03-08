using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadastro.API.Migrations
{
    public partial class CreateProcedures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[Pessoa_Insert]
                    @Nome nvarchar(max),
                    @Email nvarchar(max),
                    @Endereco nvarchar(max)
                AS
                BEGIN
                    INSERT INTO [dbo].[Pessoas] ([Nome], [Email], [Endereco]) VALUES (@Nome,  @Email, @Endereco)
                    SELECT SCOPE_IDENTITY() AS Id
                END";

            migrationBuilder.Sql(sp);
            sp =
                @"CREATE PROCEDURE [dbo].[Pessoa_Update]
                    @ID int,
                    @Nome nvarchar(max),
                    @Email nvarchar(max),
                    @Endereco nvarchar(max)
                AS  
                  UPDATE [dbo].[Pessoas]
                  SET [Nome] = @Nome, [Email] = @Email, [Endereco]= @Endereco  
                  WHERE Id = @ID;";

            migrationBuilder.Sql(sp);
            sp = @"
                CREATE PROCEDURE [dbo].[Pessoa_Delete]  
                  @Id int  
                AS  
                  DELETE FROM [dbo].[Pessoas]
                  WHERE Id = @Id";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
