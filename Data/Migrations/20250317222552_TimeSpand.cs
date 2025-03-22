using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SunSnap.Data.Migrations
{
    /// <inheritdoc />
    public partial class TimeSpand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "PeriodEnd",
                table: "Photos",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "PeriodStart",
                table: "Photos",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PeriodEnd", "PeriodStart", "UploadDate" },
                values: new object[] { new TimeSpan(0, 8, 7, 0, 0), new TimeSpan(0, 6, 45, 0, 0), new DateTime(2025, 3, 17, 22, 25, 51, 768, DateTimeKind.Utc).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PeriodEnd", "PeriodStart", "UploadDate" },
                values: new object[] { new TimeSpan(0, 11, 59, 59, 0), new TimeSpan(0, 8, 7, 0, 0), new DateTime(2025, 3, 17, 22, 25, 51, 768, DateTimeKind.Utc).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PeriodEnd", "PeriodStart", "UploadDate" },
                values: new object[] { new TimeSpan(0, 14, 59, 59, 0), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2025, 3, 17, 22, 25, 51, 768, DateTimeKind.Utc).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PeriodEnd", "PeriodStart", "UploadDate" },
                values: new object[] { new TimeSpan(0, 18, 44, 59, 0), new TimeSpan(0, 15, 0, 0, 0), new DateTime(2025, 3, 17, 22, 25, 51, 768, DateTimeKind.Utc).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PeriodEnd", "PeriodStart", "UploadDate" },
                values: new object[] { new TimeSpan(0, 19, 27, 0, 0), new TimeSpan(0, 18, 45, 0, 0), new DateTime(2025, 3, 17, 22, 25, 51, 768, DateTimeKind.Utc).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PeriodEnd", "PeriodStart", "UploadDate" },
                values: new object[] { new TimeSpan(0, 6, 44, 59, 0), new TimeSpan(0, 19, 27, 1, 0), new DateTime(2025, 3, 17, 22, 25, 51, 768, DateTimeKind.Utc).AddTicks(550) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PeriodEnd",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "PeriodStart",
                table: "Photos");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 21, 16, 7, 579, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 21, 16, 7, 579, DateTimeKind.Utc).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 21, 16, 7, 579, DateTimeKind.Utc).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 21, 16, 7, 579, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 21, 16, 7, 579, DateTimeKind.Utc).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "UploadDate",
                value: new DateTime(2025, 3, 17, 21, 16, 7, 579, DateTimeKind.Utc).AddTicks(9969));
        }
    }
}
