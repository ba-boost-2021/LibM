using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibM.Data.Access.Migrations
{
    public partial class Revize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorID",
                schema: "Definition",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Types_TypeID",
                schema: "Definition",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Books_BookID",
                schema: "Customer",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Students_StudentID",
                schema: "Customer",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                schema: "Customer",
                table: "Transactions",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "BookID",
                schema: "Customer",
                table: "Transactions",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_StudentID",
                schema: "Customer",
                table: "Transactions",
                newName: "IX_Transactions_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_BookID",
                schema: "Customer",
                table: "Transactions",
                newName: "IX_Transactions_BookId");

            migrationBuilder.RenameColumn(
                name: "TypeID",
                schema: "Definition",
                table: "Books",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "AuthorID",
                schema: "Definition",
                table: "Books",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_TypeID",
                schema: "Definition",
                table: "Books",
                newName: "IX_Books_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_AuthorID",
                schema: "Definition",
                table: "Books",
                newName: "IX_Books_AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                schema: "Definition",
                table: "Books",
                column: "AuthorId",
                principalSchema: "Definition",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Types_TypeId",
                schema: "Definition",
                table: "Books",
                column: "TypeId",
                principalSchema: "Definition",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Books_BookId",
                schema: "Customer",
                table: "Transactions",
                column: "BookId",
                principalSchema: "Definition",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Students_StudentId",
                schema: "Customer",
                table: "Transactions",
                column: "StudentId",
                principalSchema: "Customer",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                schema: "Definition",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Types_TypeId",
                schema: "Definition",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Books_BookId",
                schema: "Customer",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Students_StudentId",
                schema: "Customer",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                schema: "Customer",
                table: "Transactions",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "BookId",
                schema: "Customer",
                table: "Transactions",
                newName: "BookID");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_StudentId",
                schema: "Customer",
                table: "Transactions",
                newName: "IX_Transactions_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_BookId",
                schema: "Customer",
                table: "Transactions",
                newName: "IX_Transactions_BookID");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                schema: "Definition",
                table: "Books",
                newName: "TypeID");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                schema: "Definition",
                table: "Books",
                newName: "AuthorID");

            migrationBuilder.RenameIndex(
                name: "IX_Books_TypeId",
                schema: "Definition",
                table: "Books",
                newName: "IX_Books_TypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Books_AuthorId",
                schema: "Definition",
                table: "Books",
                newName: "IX_Books_AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorID",
                schema: "Definition",
                table: "Books",
                column: "AuthorID",
                principalSchema: "Definition",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Types_TypeID",
                schema: "Definition",
                table: "Books",
                column: "TypeID",
                principalSchema: "Definition",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Books_BookID",
                schema: "Customer",
                table: "Transactions",
                column: "BookID",
                principalSchema: "Definition",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Students_StudentID",
                schema: "Customer",
                table: "Transactions",
                column: "StudentID",
                principalSchema: "Customer",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
