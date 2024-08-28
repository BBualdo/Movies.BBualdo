using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Animation", 24.99m, new DateOnly(1999, 11, 13), "Toy Story 2" },
                    { 2, "Science Fiction", 19.99m, new DateOnly(1999, 3, 31), "The Matrix" },
                    { 3, "Action", 29.99m, new DateOnly(2010, 7, 16), "Inception" },
                    { 4, "Drama", 14.99m, new DateOnly(1994, 9, 23), "The Shawshank Redemption" },
                    { 5, "Crime", 18.99m, new DateOnly(1994, 10, 14), "Pulp Fiction" },
                    { 6, "Action", 24.99m, new DateOnly(2008, 7, 18), "The Dark Knight" },
                    { 7, "Drama", 17.99m, new DateOnly(1994, 7, 6), "Forrest Gump" },
                    { 8, "Animation", 19.99m, new DateOnly(1994, 6, 24), "The Lion King" },
                    { 9, "Action", 21.99m, new DateOnly(2000, 5, 5), "Gladiator" },
                    { 10, "Romance", 22.99m, new DateOnly(1997, 12, 19), "Titanic" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
