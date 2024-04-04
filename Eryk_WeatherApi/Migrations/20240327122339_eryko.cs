using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherProject.Migrations
{
    /// <inheritdoc />
    public partial class eryko : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "city_name",
                table: "Tabela",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "city_name",
                table: "Tabela");
        }
    }
}
