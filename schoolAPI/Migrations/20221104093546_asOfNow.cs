using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace schoolAPI.Migrations
{
    public partial class asOfNow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudentStudyProgrammes",
                columns: new[] { "StudentId", "StudyProgrammeId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name" },
                values: new object[] { "Sumit@gmail.com", "Sumit" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name" },
                values: new object[] { "Lukas@gmail.com", "Lukas" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 4, "Christoffer@gmail.com", "Christoffer" });

            migrationBuilder.InsertData(
                table: "StudentStudyProgrammes",
                columns: new[] { "StudentId", "StudyProgrammeId" },
                values: new object[] { 4, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentStudyProgrammes",
                keyColumns: new[] { "StudentId", "StudyProgrammeId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "StudentStudyProgrammes",
                keyColumns: new[] { "StudentId", "StudyProgrammeId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "StudentStudyProgrammes",
                keyColumns: new[] { "StudentId", "StudyProgrammeId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name" },
                values: new object[] { "Lukas@gmail.com", "Lukas" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name" },
                values: new object[] { "Christoffer@gmail.com", "Christoffer" });
        }
    }
}
