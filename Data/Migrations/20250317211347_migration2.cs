using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SunSnap.Data.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 21, 13, 47, 105, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FilePath", "UploadDate" },
                values: new object[] { "/photos/morning.jpg", new DateTime(2025, 3, 17, 21, 13, 47, 105, DateTimeKind.Utc).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FilePath", "UploadDate" },
                values: new object[] { "/photos/noon.jpg", new DateTime(2025, 3, 17, 21, 13, 47, 105, DateTimeKind.Utc).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FilePath", "UploadDate" },
                values: new object[] { "/photos/evening.jpg", new DateTime(2025, 3, 17, 21, 13, 47, 105, DateTimeKind.Utc).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FilePath", "UploadDate" },
                values: new object[] { "/photos/sunset.jpg", new DateTime(2025, 3, 17, 21, 13, 47, 105, DateTimeKind.Utc).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FilePath", "UploadDate" },
                values: new object[] { "/photos/night.jpg", new DateTime(2025, 3, 17, 21, 13, 47, 105, DateTimeKind.Utc).AddTicks(2129) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 20, 17, 16, 706, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FilePath", "UploadDate" },
                values: new object[] { "/photos/beach.jpg", new DateTime(2025, 3, 17, 20, 17, 16, 706, DateTimeKind.Utc).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FilePath", "UploadDate" },
                values: new object[] { "/photos/mountain.jpg", new DateTime(2025, 3, 17, 20, 17, 16, 706, DateTimeKind.Utc).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FilePath", "UploadDate" },
                values: new object[] { "/photos/mountain.jpg", new DateTime(2025, 3, 17, 20, 17, 16, 706, DateTimeKind.Utc).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FilePath", "UploadDate" },
                values: new object[] { "/photos/mountain.jpg", new DateTime(2025, 3, 17, 20, 17, 16, 706, DateTimeKind.Utc).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FilePath", "UploadDate" },
                values: new object[] { "/photos/mountain.jpg", new DateTime(2025, 3, 17, 20, 17, 16, 706, DateTimeKind.Utc).AddTicks(947) });
        }
    }
}
