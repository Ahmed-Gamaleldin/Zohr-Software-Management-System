using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ZohrChangeSystem.Migrations
{
    public partial class changeDatetoString2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "date",
                table: "changeForms",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "changeForms",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
