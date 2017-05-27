using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CineplexCinemas.Migrations
{
    public partial class Session : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    SessionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SeatsAvailable = table.Column<int>(nullable: false),
                    SeatsTotal = table.Column<int>(nullable: false),
                    SessionDate = table.Column<DateTime>(nullable: false),
                    SessionTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.SessionId);
                });

            migrationBuilder.AddColumn<int>(
                name: "SessionId",
                table: "CineplexMovie",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CineplexMovie_Session_SessionId",
                table: "CineplexMovie",
                column: "SessionId",
                principalTable: "Session",
                principalColumn: "SessionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.CreateIndex(
                name: "IX_CineplexMovie_CineplexID",
                table: "CineplexMovie",
                column: "CineplexID");

            migrationBuilder.CreateIndex(
                name: "IX_CineplexMovie_MovieID",
                table: "CineplexMovie",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_CineplexMovie_SessionId",
                table: "CineplexMovie",
                column: "SessionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Session");
        }
    }
}
