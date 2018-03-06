using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Shop.Migrations
{
    public partial class OneToOneUserAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Adress_AddressID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_AddressID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AddressID",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "AddressForeignKey",
                table: "Adress",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Adress_AddressForeignKey",
                table: "Adress",
                column: "AddressForeignKey",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Adress_User_AddressForeignKey",
                table: "Adress",
                column: "AddressForeignKey",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adress_User_AddressForeignKey",
                table: "Adress");

            migrationBuilder.DropIndex(
                name: "IX_Adress_AddressForeignKey",
                table: "Adress");

            migrationBuilder.DropColumn(
                name: "AddressForeignKey",
                table: "Adress");

            migrationBuilder.AddColumn<int>(
                name: "AddressID",
                table: "User",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_AddressID",
                table: "User",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Adress_AddressID",
                table: "User",
                column: "AddressID",
                principalTable: "Adress",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
