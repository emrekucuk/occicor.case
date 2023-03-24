using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RelUserTags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TagId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelUserTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelUserTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelUserTags_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("41766635-e22f-4b71-a1fc-c974b720475e"), "Fullstack" },
                    { new Guid("4502a8b0-7d98-4516-87ad-0d45c76febb0"), "Backend" },
                    { new Guid("49c305f9-5927-4df4-9b6d-afa0c34771b5"), "Web Developer" },
                    { new Guid("7ecbd3c6-ae49-4d9f-a5a9-198b49f8fb30"), "Software Developer" },
                    { new Guid("ce0f63de-b59a-4a09-a5fe-4fa52de402ba"), "Frontend" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("56d1fcf1-1807-4211-9315-43507193444c"), "john@hotmail.com", "Mary", "Doe", "05451265284" },
                    { new Guid("f973d74b-b7df-40a6-a530-017dcdd870e7"), "john@hotmail.com", "John", "Doe", "05451265284" }
                });

            migrationBuilder.InsertData(
                table: "RelUserTags",
                columns: new[] { "Id", "TagId", "UserId" },
                values: new object[,]
                {
                    { new Guid("21893aeb-056e-4e4a-a758-fed2e03cb3e8"), new Guid("4502a8b0-7d98-4516-87ad-0d45c76febb0"), new Guid("f973d74b-b7df-40a6-a530-017dcdd870e7") },
                    { new Guid("24093bd9-6fe5-4c19-b03e-20d8c54acaa3"), new Guid("41766635-e22f-4b71-a1fc-c974b720475e"), new Guid("56d1fcf1-1807-4211-9315-43507193444c") },
                    { new Guid("6271588b-3f29-4cfc-8c03-0a914c76384b"), new Guid("7ecbd3c6-ae49-4d9f-a5a9-198b49f8fb30"), new Guid("f973d74b-b7df-40a6-a530-017dcdd870e7") },
                    { new Guid("915c5232-f0dd-4c74-b42e-ab3c7fc28877"), new Guid("7ecbd3c6-ae49-4d9f-a5a9-198b49f8fb30"), new Guid("56d1fcf1-1807-4211-9315-43507193444c") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RelUserTags_TagId",
                table: "RelUserTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_RelUserTags_UserId",
                table: "RelUserTags",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelUserTags");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
