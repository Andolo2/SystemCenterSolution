using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemCenter01.Migrations
{
    /// <inheritdoc />
    public partial class RemovedTickedIDAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Tickets_TicketsId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_TicketsId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TicketsId",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TicketsId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_TicketsId",
                table: "Users",
                column: "TicketsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Tickets_TicketsId",
                table: "Users",
                column: "TicketsId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
