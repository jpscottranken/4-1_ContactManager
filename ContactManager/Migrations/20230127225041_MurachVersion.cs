using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactManager.Migrations
{
    public partial class MurachVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2019, 12, 19, 18, 2, 51, 201, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2019, 12, 19, 18, 2, 51, 203, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2019, 12, 19, 18, 2, 51, 203, DateTimeKind.Local).AddTicks(5117));
        }
    }
}
