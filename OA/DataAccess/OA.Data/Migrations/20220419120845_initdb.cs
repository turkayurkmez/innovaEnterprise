using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OA.Data.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Electronics" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Clothes" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Books" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, 1, null, null, null, null, "Laptop", 1200m, 10 },
                    { 2, 1, null, null, null, null, "Mouse", 50m, 20 },
                    { 3, 1, null, null, null, null, "Keyboard", 100m, 30 },
                    { 4, 1, null, null, null, null, "Monitor", 500m, 40 },
                    { 5, 1, null, null, null, null, "CPU", 1000m, 50 },
                    { 6, 1, null, null, null, null, "RAM", 100m, 60 },
                    { 7, 1, null, null, null, null, "HDD", 500m, 70 },
                    { 8, 1, null, null, null, null, "SSD", 1000m, 80 },
                    { 9, 2, null, null, null, null, "Laptop", 1200m, 90 },
                    { 10, 2, null, null, null, null, "Mouse", 50m, 100 },
                    { 11, 2, null, null, null, null, "Keyboard", 100m, 110 },
                    { 12, 2, null, null, null, null, "Monitor", 500m, 120 },
                    { 13, 2, null, null, null, null, "CPU", 1000m, 130 },
                    { 14, 2, null, null, null, null, "RAM", 100m, 140 },
                    { 15, 2, null, null, null, null, "HDD", 500m, 150 },
                    { 16, 2, null, null, null, null, "SSD", 1000m, 160 },
                    { 17, 3, null, null, null, null, "Laptop", 1200m, 170 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
