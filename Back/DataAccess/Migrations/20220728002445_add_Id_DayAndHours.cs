using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymDataAccess.Migrations
{
    public partial class add_Id_DayAndHours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "DayAndHour",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ActivityId",
                table: "DayAndHour",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DayAndHour",
                table: "DayAndHour",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DayAndHour_ActivityId",
                table: "DayAndHour",
                column: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_DayAndHour_Activities_ActivityId",
                table: "DayAndHour",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DayAndHour_Activities_ActivityId",
                table: "DayAndHour");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DayAndHour",
                table: "DayAndHour");

            migrationBuilder.DropIndex(
                name: "IX_DayAndHour_ActivityId",
                table: "DayAndHour");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DayAndHour");

            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "DayAndHour");
        }
    }
}
