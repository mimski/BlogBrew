﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogBrew.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Technology" },
                    { 2, null, "Health" },
                    { 3, null, "LifeStyle" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "CategoryId", "Content", "ImagePath", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1, "John Doe", 1, "Content of Tech Post", "tech.jpg", new DateTime(2025, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tech Post" },
                    { 2, "Jane Doe", 2, "Content of Health Post", "health.jpg", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Health Post" },
                    { 3, "Jane Doe", 3, "Content of Lifestyle Post", "lifestyle.jpg", new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lifestyle Post" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
