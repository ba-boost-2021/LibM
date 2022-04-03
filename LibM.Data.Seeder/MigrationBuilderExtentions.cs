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
                values: new object[] { new Guid("FF92B0FB-3839-41AA-BEDA-D53C3195D2F6"), "Roman", DateTime.Now, DateTime.Now });

            migrationBuilder.InsertData(
                schema: "Definition",
                table: "Types",
                columns: new string[] { "Id", "Name", "CreatedAt", "ModifiedAt" },
                values: new object[] { new Guid("FF92B0FB-3839-41AA-BEDA-D53C3195D2F7"), "Polisiye", DateTime.Now, DateTime.Now });

            migrationBuilder.InsertData(
                schema: "Definition",
                table: "Types",
                columns: new string[] { "Id", "Name", "CreatedAt", "ModifiedAt" },
                values: new object[] { new Guid("FF92B0FB-3839-41AA-BEDA-D53C3195D2F8"), "Bilim", DateTime.Now, DateTime.Now });

            migrationBuilder.InsertData(
               schema: "Definition",
               table: "Authors",
               columns: new string[] { "Id", "FirstName", "LastName","CreatedAt","ModifiedAt" },
               values: new object[] { new Guid("A61F61EE-F592-4FCA-91D8-A464FE9A3B32"), "Sergen","Kahraman", DateTime.Now, DateTime.Now });

            migrationBuilder.InsertData(
               schema: "Definition",
               table: "Authors",
               columns: new string[] { "Id", "FirstName", "LastName", "CreatedAt", "ModifiedAt" },
               values: new object[] { new Guid("A61F61EE-F592-4FCA-91D8-A464FE9A3B33"), "İsmail", "Kara", DateTime.Now, DateTime.Now });

            migrationBuilder.InsertData(
               schema: "Definition",
               table: "Authors",
               columns: new string[] { "Id", "FirstName", "LastName", "CreatedAt", "ModifiedAt" },
               values: new object[] { new Guid("A61F61EE-F592-4FCA-91D8-A464FE9A3B34"), "Metehan", "Çam", DateTime.Now, DateTime.Now });

            migrationBuilder.InsertData(
               schema: "Definition",
               table: "Books",
               columns: new string[] { "Id", "Name", "AuthorId", "PageCount", "Available", "TypeId", "CreatedAt", "ModifiedAt" },
               values: new object[] { new Guid("F3AD5326-5AE6-4166-907B-D26D3B250947"), "Yapay Zakanın Olgunluk Çağı", new Guid("A61F61EE-F592-4FCA-91D8-A464FE9A3B32"), 100, true, new Guid("FF92B0FB-3839-41AA-BEDA-D53C3195D2F8"), DateTime.Now, DateTime.Now });

            migrationBuilder.InsertData(
               schema: "Definition",
               table: "Books",
               columns: new string[] { "Id", "Name", "AuthorId", "PageCount", "Available", "TypeId", "CreatedAt", "ModifiedAt" },
               values: new object[] { new Guid("F3AD5326-5AE6-4166-907B-D26D3B250946"), "Tanrı Zar Atmaz", new Guid("A61F61EE-F592-4FCA-91D8-A464FE9A3B33"), 100, true, new Guid("FF92B0FB-3839-41AA-BEDA-D53C3195D2F8"), DateTime.Now, DateTime.Now });

            migrationBuilder.InsertData(
               schema: "Definition",
               table: "Books",
               columns: new string[] { "Id", "Name", "AuthorId", "PageCount", "Available", "TypeId", "CreatedAt", "ModifiedAt" },
               values: new object[] { new Guid("F3AD5326-5AE6-4166-907B-D26D3B250948"), "C# ile Programlama", new Guid("A61F61EE-F592-4FCA-91D8-A464FE9A3B32"), 110, true, new Guid("FF92B0FB-3839-41AA-BEDA-D53C3195D2F8"), DateTime.Now, DateTime.Now });

            migrationBuilder.InsertData(
               schema: "Definition",
               table: "Books",
               columns: new string[] { "Id", "Name", "AuthorId", "PageCount", "Available", "TypeId", "CreatedAt", "ModifiedAt" },
               values: new object[] { new Guid("F3AD5326-5AE6-4166-907B-D26D3B250949"), "Ejderha Dövmeli Kız", new Guid("A61F61EE-F592-4FCA-91D8-A464FE9A3B34"), 200, true, new Guid("FF92B0FB-3839-41AA-BEDA-D53C3195D2F7"), DateTime.Now, DateTime.Now });

            migrationBuilder.InsertData(
               schema: "Definition",
               table: "Books",
               columns: new string[] { "Id", "Name", "AuthorId", "PageCount", "Available", "TypeId", "CreatedAt", "ModifiedAt" },
               values: new object[] { new Guid("F3AD5326-5AE6-4166-907B-D26D3B250950"), "Kürk Mantolu Maddona", new Guid("A61F61EE-F592-4FCA-91D8-A464FE9A3B34"), 210, true, new Guid("FF92B0FB-3839-41AA-BEDA-D53C3195D2F6"), DateTime.Now, DateTime.Now });

            migrationBuilder.InsertData(
               schema: "Management",
               table: "Employees",
               columns: new string[] { "Id", "FirstName", "LastName", "Phone", "CreatedAt", "ModifiedAt" },
               values: new object[] { new Guid("F0AD9565-903E-4957-9E6B-3FAB3FDBD3D2"), "Kadir Osman","Üst", "0555-555-55-55", DateTime.Now, DateTime.Now });

            migrationBuilder.InsertData(
               schema: "Customer",
               table: "Students",
               columns: new string[] { "Id", "FirstName", "LastName", "Gender", "BirthDate", "Grade", "CreatedAt", "ModifiedAt" },
               values: new object[] { new Guid("0F8BFE0A-E194-4A6B-BFB4-DBE4C306442A"), "Ahmet", "Çelik", 2, DateTime.Now.AddYears(-19), "11-A", DateTime.Now, DateTime.Now });

            migrationBuilder.InsertData(
               schema: "Customer",
               table: "Students",
               columns: new string[] { "Id", "FirstName", "LastName", "Gender", "BirthDate", "Grade", "CreatedAt", "ModifiedAt" },
               values: new object[] { new Guid("0F8BFE0A-E194-4A6B-BFB4-DBE4C306442F"), "Melis", "Demir", 1, DateTime.Now.AddYears(-18), "10-B", DateTime.Now, DateTime.Now });
        }
    }
}
