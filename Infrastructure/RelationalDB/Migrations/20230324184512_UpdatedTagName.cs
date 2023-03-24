using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTagName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("41766635-e22f-4b71-a1fc-c974b720475e"),
                column: "Name",
                value: "Çilek");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4502a8b0-7d98-4516-87ad-0d45c76febb0"),
                column: "Name",
                value: "Armut");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("49c305f9-5927-4df4-9b6d-afa0c34771b5"),
                column: "Name",
                value: "Muz");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7ecbd3c6-ae49-4d9f-a5a9-198b49f8fb30"),
                column: "Name",
                value: "Elma");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ce0f63de-b59a-4a09-a5fe-4fa52de402ba"),
                column: "Name",
                value: "Ayva");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("41766635-e22f-4b71-a1fc-c974b720475e"),
                column: "Name",
                value: "Fullstack");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4502a8b0-7d98-4516-87ad-0d45c76febb0"),
                column: "Name",
                value: "Backend");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("49c305f9-5927-4df4-9b6d-afa0c34771b5"),
                column: "Name",
                value: "Web Developer");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7ecbd3c6-ae49-4d9f-a5a9-198b49f8fb30"),
                column: "Name",
                value: "Software Developer");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ce0f63de-b59a-4a09-a5fe-4fa52de402ba"),
                column: "Name",
                value: "Frontend");
        }
    }
}
