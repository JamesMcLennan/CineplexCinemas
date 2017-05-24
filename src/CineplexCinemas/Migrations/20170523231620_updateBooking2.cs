using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CineplexCinemas.Migrations
{
    public partial class updateBooking2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Movie_MovieId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Session_SessionId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_MovieId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_SessionId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "Booking");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Booking",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SessionId",
                table: "Booking",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_MovieId",
                table: "Booking",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_SessionId",
                table: "Booking",
                column: "SessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Movie_MovieId",
                table: "Booking",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Session_SessionId",
                table: "Booking",
                column: "SessionId",
                principalTable: "Session",
                principalColumn: "SessionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
