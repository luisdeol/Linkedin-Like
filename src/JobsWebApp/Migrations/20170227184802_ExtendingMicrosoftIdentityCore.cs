using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobsWebApp.Migrations
{
    public partial class ExtendingMicrosoftIdentityCore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "Security",
                table: "AspNetUser");

            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "Security",
                table: "AspNetUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "Security",
                table: "AspNetUser",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "Security",
                table: "AspNetUser",
                nullable: true);
        }
    }
}
