using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class GehScheissn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ADDONS",
                columns: table => new
                {
                    ELEMENT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CODE = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRICE = table.Column<int>(type: "int", nullable: false),
                    IMAGE = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADDONS", x => x.ELEMENT_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UPGRADEABLES",
                columns: table => new
                {
                    ELEMENT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ADDON_ID = table.Column<int>(type: "int", nullable: true),
                    CODE = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRICE = table.Column<int>(type: "int", nullable: false),
                    IMAGE = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UPGRADEABLES", x => x.ELEMENT_ID);
                    table.ForeignKey(
                        name: "FK_UPGRADEABLES_ADDONS_ADDON_ID",
                        column: x => x.ADDON_ID,
                        principalTable: "ADDONS",
                        principalColumn: "ELEMENT_ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TRUCKS",
                columns: table => new
                {
                    ELEMENT_ID = table.Column<int>(type: "int", nullable: false),
                    PULL_FORCE = table.Column<int>(type: "int", nullable: false),
                    SPEED = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRUCKS", x => x.ELEMENT_ID);
                    table.ForeignKey(
                        name: "FK_TRUCKS_UPGRADEABLES_ELEMENT_ID",
                        column: x => x.ELEMENT_ID,
                        principalTable: "UPGRADEABLES",
                        principalColumn: "ELEMENT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CONVOYS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CODE = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FRONT_TRUCK_ID = table.Column<int>(type: "int", nullable: true),
                    BACK_TRUCK_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONVOYS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CONVOYS_TRUCKS_BACK_TRUCK_ID",
                        column: x => x.BACK_TRUCK_ID,
                        principalTable: "TRUCKS",
                        principalColumn: "ELEMENT_ID");
                    table.ForeignKey(
                        name: "FK_CONVOYS_TRUCKS_FRONT_TRUCK_ID",
                        column: x => x.FRONT_TRUCK_ID,
                        principalTable: "TRUCKS",
                        principalColumn: "ELEMENT_ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WAGONS",
                columns: table => new
                {
                    ELEMENT_ID = table.Column<int>(type: "int", nullable: false),
                    TRUCK_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WAGONS", x => x.ELEMENT_ID);
                    table.ForeignKey(
                        name: "FK_WAGONS_TRUCKS_TRUCK_ID",
                        column: x => x.TRUCK_ID,
                        principalTable: "TRUCKS",
                        principalColumn: "ELEMENT_ID");
                    table.ForeignKey(
                        name: "FK_WAGONS_UPGRADEABLES_ELEMENT_ID",
                        column: x => x.ELEMENT_ID,
                        principalTable: "UPGRADEABLES",
                        principalColumn: "ELEMENT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CONVOYS_BACK_TRUCK_ID",
                table: "CONVOYS",
                column: "BACK_TRUCK_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CONVOYS_FRONT_TRUCK_ID",
                table: "CONVOYS",
                column: "FRONT_TRUCK_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UPGRADEABLES_ADDON_ID",
                table: "UPGRADEABLES",
                column: "ADDON_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WAGONS_TRUCK_ID",
                table: "WAGONS",
                column: "TRUCK_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CONVOYS");

            migrationBuilder.DropTable(
                name: "WAGONS");

            migrationBuilder.DropTable(
                name: "TRUCKS");

            migrationBuilder.DropTable(
                name: "UPGRADEABLES");

            migrationBuilder.DropTable(
                name: "ADDONS");
        }
    }
}
