using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class primeira_migracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_USUARIO",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataInclusao = table.Column<DateTime>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    Status = table.Column<string>(maxLength: 1, nullable: false),
                    Nome = table.Column<string>(maxLength: 120, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Login = table.Column<string>(maxLength: 100, nullable: false),
                    Senha = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIO", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_USUARIO_Email",
                table: "TB_USUARIO",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TB_USUARIO_Login",
                table: "TB_USUARIO",
                column: "Login",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_USUARIO");
        }
    }
}
