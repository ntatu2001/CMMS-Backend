﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPICHATest.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMaterialInfor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MaterialInforId",
                table: "MaterialHistoryCards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MaterialInforId",
                table: "MaterialHistoryCards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
