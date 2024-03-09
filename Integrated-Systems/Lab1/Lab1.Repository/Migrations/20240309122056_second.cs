using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab1.Repository.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcertUserId1",
                table: "Tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ConcertId",
                table: "Tickets",
                column: "ConcertId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ConcertUserId1",
                table: "Tickets",
                column: "ConcertUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_ConcertUserId1",
                table: "Tickets",
                column: "ConcertUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Concerts_ConcertId",
                table: "Tickets",
                column: "ConcertId",
                principalTable: "Concerts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_ConcertUserId1",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Concerts_ConcertId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ConcertId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ConcertUserId1",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ConcertUserId1",
                table: "Tickets");
        }
    }
}
