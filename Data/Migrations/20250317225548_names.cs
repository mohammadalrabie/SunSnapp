using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SunSnap.Data.Migrations
{
    /// <inheritdoc />
    public partial class names : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 22, 55, 48, 244, DateTimeKind.Utc).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 22, 55, 48, 244, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 22, 55, 48, 244, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 22, 55, 48, 244, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 22, 55, 48, 244, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 22, 55, 48, 244, DateTimeKind.Utc).AddTicks(4624));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 22, 25, 51, 768, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 22, 25, 51, 768, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 22, 25, 51, 768, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 22, 25, 51, 768, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 22, 25, 51, 768, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 22, 25, 51, 768, DateTimeKind.Utc).AddTicks(550));
        }
    }
}
