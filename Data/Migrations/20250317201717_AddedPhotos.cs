using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SunSnap.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedPhotos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UploadDate = table.Column<DateTime>(type: "datetime2", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "FileName", "FilePath", "UploadDate" },
                values: new object[,]
                {
                    { 1, "sunrise.png", "/photos/sunrise.png", new DateTime(2025, 3, 17, 20, 17, 16, 706, DateTimeKind.Utc).AddTicks(941) },
                    { 2, "morning.png", "/photos/beach.jpg", new DateTime(2025, 3, 17, 20, 17, 16, 706, DateTimeKind.Utc).AddTicks(944) },
                    { 3, "noon.png", "/photos/mountain.jpg", new DateTime(2025, 3, 17, 20, 17, 16, 706, DateTimeKind.Utc).AddTicks(945) },
                    { 4, "evening.png", "/photos/mountain.jpg", new DateTime(2025, 3, 17, 20, 17, 16, 706, DateTimeKind.Utc).AddTicks(946) },
                    { 5, "sunset.png", "/photos/mountain.jpg", new DateTime(2025, 3, 17, 20, 17, 16, 706, DateTimeKind.Utc).AddTicks(946) },
                    { 6, "night.png", "/photos/mountain.jpg", new DateTime(2025, 3, 17, 20, 17, 16, 706, DateTimeKind.Utc).AddTicks(947) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");
        }
    }
}
