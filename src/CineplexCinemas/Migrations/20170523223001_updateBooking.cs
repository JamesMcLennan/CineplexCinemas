using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CineplexCinemas.Migrations
{
    public partial class updateBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SessionDetailsCineplexId",
                table: "Booking",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SessionDetailsMovieId",
                table: "Booking",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SessionDetailsSessionId",
                table: "Booking",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_SessionDetailsCineplexId_SessionDetailsMovieId_SessionDetailsSessionId",
                table: "Booking",
                columns: new[] { "SessionDetailsCineplexId", "SessionDetailsMovieId", "SessionDetailsSessionId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_CineplexMovie_SessionDetailsCineplexId_SessionDetailsMovieId_SessionDetailsSessionId",
                table: "Booking",
                columns: new[] { "SessionDetailsCineplexId", "SessionDetailsMovieId", "SessionDetailsSessionId" },
                principalTable: "CineplexMovie",
                principalColumns: new[] { "CineplexID", "MovieID", "SessionId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_CineplexMovie_SessionDetailsCineplexId_SessionDetailsMovieId_SessionDetailsSessionId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_SessionDetailsCineplexId_SessionDetailsMovieId_SessionDetailsSessionId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "SessionDetailsCineplexId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "SessionDetailsMovieId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "SessionDetailsSessionId",
                table: "Booking");
        }
    }
}
