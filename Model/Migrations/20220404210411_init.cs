using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CONVOYS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ConvoyName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONVOYS", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VEHICLES",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEHICLES", x => x.VehicleId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ADDONS",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADDONS", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_ADDONS_VEHICLES_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "VEHICLES",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SLOTS",
                columns: table => new
                {
                    SlotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsDamaged = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CurrentItem = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLOTS", x => x.SlotId);
                    table.ForeignKey(
                        name: "FK_SLOTS_VEHICLES_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "VEHICLES",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TRUCKS",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    ConvoyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRUCKS", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_TRUCKS_CONVOYS_ConvoyId",
                        column: x => x.ConvoyId,
                        principalTable: "CONVOYS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TRUCKS_VEHICLES_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "VEHICLES",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WAGONS",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    TruckId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WAGONS", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_WAGONS_TRUCKS_TruckId",
                        column: x => x.TruckId,
                        principalTable: "TRUCKS",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WAGONS_VEHICLES_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "VEHICLES",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_SLOTS_VehicleId",
                table: "SLOTS",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_TRUCKS_ConvoyId",
                table: "TRUCKS",
                column: "ConvoyId");

            migrationBuilder.CreateIndex(
                name: "IX_WAGONS_TruckId",
                table: "WAGONS",
                column: "TruckId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADDONS");

            migrationBuilder.DropTable(
                name: "SLOTS");

            migrationBuilder.DropTable(
                name: "WAGONS");

            migrationBuilder.DropTable(
                name: "TRUCKS");

            migrationBuilder.DropTable(
                name: "CONVOYS");

            migrationBuilder.DropTable(
                name: "VEHICLES");
        }
    }
}
