using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CineplexCinemas.Migrations
{
    public partial class movieToSession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "filmMovieId",
                table: "Session",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Session_filmMovieId",
                table: "Session",
                column: "filmMovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Movie_filmMovieId",
                table: "Session",
                column: "filmMovieId",
                principalTable: "Movie",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Session_Movie_filmMovieId",
                table: "Session");

            migrationBuilder.DropIndex(
                name: "IX_Session_filmMovieId",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "filmMovieId",
                table: "Session");
        }
    }
}
