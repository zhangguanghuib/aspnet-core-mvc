using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FakeXiecheng.API.Migrations
{
    public partial class UpdateTouristRouteSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartureCity",
                table: "TouristRoutes",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "TouristRoutes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TravelDays",
                table: "TouristRoutes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TripType",
                table: "TouristRoutes",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("106e9a23-681c-4206-a197-c14d58221410"),
                columns: new[] { "DepartureCity", "Rating", "TravelDays", "TripType" },
                values: new object[] { 2, 3.5, 8, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartureCity",
                table: "TouristRoutes");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "TouristRoutes");

            migrationBuilder.DropColumn(
                name: "TravelDays",
                table: "TouristRoutes");

            migrationBuilder.DropColumn(
                name: "TripType",
                table: "TouristRoutes");
        }
    }
}
