using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Shop.Migrations
{
    public partial class OneToOneProductProductCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adress_User_UserId",
                table: "Adress");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Order_OrderID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductCategory_ProductCategoryID",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductCategoryID",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adress",
                table: "Adress");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "ProductCategory");

            migrationBuilder.DropColumn(
                name: "ProductCategoryID",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Adress",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "Product",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Product",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Product_OrderID",
                table: "Product",
                newName: "IX_Product_OrderId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Order",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductCategory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_UserId",
                table: "Address",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Order_OrderId",
                table: "Product",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Product_ProductId",
                table: "ProductCategory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_UserId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Order_OrderId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Product_ProductId",
                table: "ProductCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductCategory");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Product",
                newName: "OrderID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Product",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_OrderId",
                table: "Product",
                newName: "IX_Product_OrderID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Order",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "ProductCategory",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryID",
                table: "Product",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adress",
                table: "Adress",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryID",
                table: "Product",
                column: "ProductCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Adress_User_UserId",
                table: "Adress",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Order_OrderID",
                table: "Product",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductCategory_ProductCategoryID",
                table: "Product",
                column: "ProductCategoryID",
                principalTable: "ProductCategory",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
