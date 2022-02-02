using Microsoft.EntityFrameworkCore.Migrations;

namespace CarShop_REST_API.Migrations
{
    public partial class Appointment_Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Finished",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentIDAppointment",
                table: "WorkOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_AppointmentIDAppointment",
                table: "WorkOrders",
                column: "AppointmentIDAppointment");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOrders_Appointments_AppointmentIDAppointment",
                table: "WorkOrders",
                column: "AppointmentIDAppointment",
                principalTable: "Appointments",
                principalColumn: "IDAppointment",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkOrders_Appointments_AppointmentIDAppointment",
                table: "WorkOrders");

            migrationBuilder.DropIndex(
                name: "IX_WorkOrders_AppointmentIDAppointment",
                table: "WorkOrders");

            migrationBuilder.DropColumn(
                name: "AppointmentIDAppointment",
                table: "WorkOrders");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Appointments");

            migrationBuilder.AddColumn<bool>(
                name: "Finished",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
