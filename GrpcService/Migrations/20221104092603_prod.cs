using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrpcService.Migrations
{
    public partial class prod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Subject", "Title" },
                values: new object[] { "sumit", "How to code", "C#" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Author",
                value: "christoffer");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Author",
                value: "Author3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReleaseDate",
                table: "Books",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "ReleaseDate", "Subject", "Title" },
                values: new object[] { "TestAuthor1", "11/2/2022 4:22:03 PM", "System integration", "Enterprise integration patterns" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "ReleaseDate" },
                values: new object[] { "TestAuthor2", "11/2/2022 4:22:03 PM" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "ReleaseDate" },
                values: new object[] { "TestAuthor3", "11/2/2022 4:22:03 PM" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: "11/2/2022 4:22:03 PM");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "IsAvailable", "Price", "ReleaseDate", "StudyProgrammeId", "Subject", "Title" },
                values: new object[,]
                {
                    { 5, "TestAuthor5", true, 150.0, "11/2/2022 4:22:03 PM", 3, "Test", "Unit testing" },
                    { 6, "TestAuthor6", true, 350.0, "11/2/2022 4:22:03 PM", 3, "Test", "Integration testing" }
                });
        }
    }
}
