using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibM.Data.Access.Migrations
{
    public partial class RevizeOnTransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BorrowingData",
                schema: "Customer",
                table: "Transactions",
                newName: "BorrowingDate");

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                schema: "Customer",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("f0ad9565-903e-4957-9e6b-3fab3fdbd3d2"));

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_EmployeeId",
                schema: "Customer",
                table: "Transactions",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Employees_EmployeeId",
                schema: "Customer",
                table: "Transactions",
                column: "EmployeeId",
                principalSchema: "Management",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Employees_EmployeeId",
                schema: "Customer",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_EmployeeId",
                schema: "Customer",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                schema: "Customer",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "BorrowingDate",
                schema: "Customer",
                table: "Transactions",
                newName: "BorrowingData");
        }
    }
}
