using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCoordinatesAndCountryToSavedLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "SavedLocations",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Lat",
                table: "SavedLocations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Lon",
                table: "SavedLocations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "SavedLocations");

            migrationBuilder.DropColumn(
                name: "Lat",
                table: "SavedLocations");

            migrationBuilder.DropColumn(
                name: "Lon",
                table: "SavedLocations");
        }
    }
}
