using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactManager.Migrations
{
    public partial class JPSInitialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 1, 31, 12, 48, 23, 9, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 1, 31, 12, 48, 23, 12, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 1, 31, 12, 48, 23, 12, DateTimeKind.Local).AddTicks(3749));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 16, 50, 41, 484, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 16, 50, 41, 486, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 16, 50, 41, 486, DateTimeKind.Local).AddTicks(6757));
        }
    }
}
