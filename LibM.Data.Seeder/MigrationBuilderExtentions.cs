using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibM.Data.Seeder
{
    public static class MigrationBuilderExtentions
    {
        public static void InitialSeeder(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Definition",
                table: "Types",
                columns: new string[] { "Id", "Name", "CreatedAt", "ModifiedAt" },
                values: new object[] { new Guid("FF92B0FB-3839-41AA-BEDA-D53C3195D2F6"), "Type1", DateTime.Now, DateTime.Now });

            migrationBuilder.InsertData(
               schema: "Definition",
               table: "Authors",
               columns: new string[] { "Id", "FirstName", "LastName","CreatedAt","ModifiedAt" },
               values: new object[] { new Guid("A61F61EE-F592-4FCA-91D8-A464FE9A3B32"), "Sergen","Kahraman", DateTime.Now, DateTime.Now });
        }
    }
}
