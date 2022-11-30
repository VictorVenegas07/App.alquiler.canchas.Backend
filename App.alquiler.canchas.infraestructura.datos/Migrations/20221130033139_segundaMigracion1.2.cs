using Microsoft.EntityFrameworkCore.Migrations;

namespace App.canchas.infraestructura.datos.Migrations
{
    public partial class segundaMigracion12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReferenciaPago",
                table: "Pagos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReferenciaPago",
                table: "Pagos");
        }
    }
}
