﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace RentaCar.Migrations
{
    public partial class CreateCarTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    DoorCount = table.Column<int>(nullable: false),
                    SeatCount = table.Column<int>(nullable: false),
                    Luggage = table.Column<string>(nullable: true),
                    Transmission = table.Column<bool>(nullable: false),
                    AirConditioning = table.Column<bool>(nullable: false),
                    MinAge = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
