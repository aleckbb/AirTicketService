using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirTicketDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_User_ExternalId",
                table: "User",
                column: "ExternalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Town_ExternalId",
                table: "Town",
                column: "ExternalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ExternalId",
                table: "Ticket",
                column: "ExternalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Role_ExternalId",
                table: "Role",
                column: "ExternalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Flight_ExternalId",
                table: "Flight",
                column: "ExternalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Country_ExternalId",
                table: "Country",
                column: "ExternalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClassFlight_ExternalId",
                table: "ClassFlight",
                column: "ExternalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Class_ExternalId",
                table: "Class",
                column: "ExternalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Airport_ExternalId",
                table: "Airport",
                column: "ExternalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Airline_ExternalId",
                table: "Airline",
                column: "ExternalId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_ExternalId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Town_ExternalId",
                table: "Town");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_ExternalId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Role_ExternalId",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Flight_ExternalId",
                table: "Flight");

            migrationBuilder.DropIndex(
                name: "IX_Country_ExternalId",
                table: "Country");

            migrationBuilder.DropIndex(
                name: "IX_ClassFlight_ExternalId",
                table: "ClassFlight");

            migrationBuilder.DropIndex(
                name: "IX_Class_ExternalId",
                table: "Class");

            migrationBuilder.DropIndex(
                name: "IX_Airport_ExternalId",
                table: "Airport");

            migrationBuilder.DropIndex(
                name: "IX_Airline_ExternalId",
                table: "Airline");
        }
    }
}
