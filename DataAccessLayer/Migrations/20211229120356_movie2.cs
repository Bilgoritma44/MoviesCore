using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class movie2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_Movies_MovieId",
                table: "Cinemas");

            migrationBuilder.DropIndex(
                name: "IX_Cinemas_MovieId",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "MovieCategory",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieCinema",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Cinemas");

            migrationBuilder.AddColumn<int>(
                name: "CinemaId",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                column: "CinemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "CinemaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CinemaId",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "MovieCategory",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MovieCinema",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Cinemas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_MovieId",
                table: "Cinemas",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_Movies_MovieId",
                table: "Cinemas",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
