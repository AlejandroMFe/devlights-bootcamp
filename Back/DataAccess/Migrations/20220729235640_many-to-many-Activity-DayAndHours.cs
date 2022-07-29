using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymDataAccess.Migrations
{
    public partial class manytomanyActivityDayAndHours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DayAndHour_Activities_ActivityId",
                table: "DayAndHour");

            migrationBuilder.DropIndex(
                name: "IX_DayAndHour_ActivityId",
                table: "DayAndHour");

            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "DayAndHour");

            migrationBuilder.AddColumn<string>(
                name: "Hour",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ActivityDayAndHour",
                columns: table => new
                {
                    ActivtiesId = table.Column<int>(type: "int", nullable: false),
                    DaysAndHoursId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityDayAndHour", x => new { x.ActivtiesId, x.DaysAndHoursId });
                    table.ForeignKey(
                        name: "FK_ActivityDayAndHour_Activities_ActivtiesId",
                        column: x => x.ActivtiesId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityDayAndHour_DayAndHour_DaysAndHoursId",
                        column: x => x.DaysAndHoursId,
                        principalTable: "DayAndHour",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityDayAndHour_DaysAndHoursId",
                table: "ActivityDayAndHour",
                column: "DaysAndHoursId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityDayAndHour");

            migrationBuilder.DropColumn(
                name: "Hour",
                table: "Activities");

            migrationBuilder.AddColumn<int>(
                name: "ActivityId",
                table: "DayAndHour",
                type: "int",
                nullable: true);

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
    }
}
