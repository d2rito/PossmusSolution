using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Possmus.Migrations
{
    /// <inheritdoc />
    public partial class Empleo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleos_Candidatos_candidatoId",
                table: "Empleos");

            migrationBuilder.RenameColumn(
                name: "candidatoId",
                table: "Empleos",
                newName: "CandidatoId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleos_candidatoId",
                table: "Empleos",
                newName: "IX_Empleos_CandidatoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleos_Candidatos_CandidatoId",
                table: "Empleos",
                column: "CandidatoId",
                principalTable: "Candidatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleos_Candidatos_CandidatoId",
                table: "Empleos");

            migrationBuilder.RenameColumn(
                name: "CandidatoId",
                table: "Empleos",
                newName: "candidatoId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleos_CandidatoId",
                table: "Empleos",
                newName: "IX_Empleos_candidatoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleos_Candidatos_candidatoId",
                table: "Empleos",
                column: "candidatoId",
                principalTable: "Candidatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
