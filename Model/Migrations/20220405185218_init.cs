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
                name: "ADDONS",
                columns: table => new
                {
                    ELEMENT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CODE = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRICE = table.Column<int>(type: "int", nullable: false),
                    IMAGE_URL = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADDONS", x => x.ELEMENT_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TRUCKS",
                columns: table => new
                {
                    ELEMENT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CAPACITY = table.Column<int>(type: "int", nullable: false),
                    SPEED = table.Column<int>(type: "int", nullable: false),
                    CODE = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRICE = table.Column<int>(type: "int", nullable: false),
                    IMAGE_URL = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ADDON_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRUCKS", x => x.ELEMENT_ID);
                    table.ForeignKey(
                        name: "FK_TRUCKS_ADDONS_ADDON_ID",
                        column: x => x.ADDON_ID,
                        principalTable: "ADDONS",
                        principalColumn: "ELEMENT_ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CONVOY",
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
                    table.PrimaryKey("PK_CONVOY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CONVOY_TRUCKS_BACK_TRUCK_ID",
                        column: x => x.BACK_TRUCK_ID,
                        principalTable: "TRUCKS",
                        principalColumn: "ELEMENT_ID");
                    table.ForeignKey(
                        name: "FK_CONVOY_TRUCKS_FRONT_TRUCK_ID",
                        column: x => x.FRONT_TRUCK_ID,
                        principalTable: "TRUCKS",
                        principalColumn: "ELEMENT_ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WAGGONS",
                columns: table => new
                {
                    ELEMENT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TRUCK_ID = table.Column<int>(type: "int", nullable: true),
                    CODE = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRICE = table.Column<int>(type: "int", nullable: false),
                    IMAGE_URL = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ADDON_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WAGGONS", x => x.ELEMENT_ID);
                    table.ForeignKey(
                        name: "FK_WAGGONS_ADDONS_ADDON_ID",
                        column: x => x.ADDON_ID,
                        principalTable: "ADDONS",
                        principalColumn: "ELEMENT_ID");
                    table.ForeignKey(
                        name: "FK_WAGGONS_TRUCKS_TRUCK_ID",
                        column: x => x.TRUCK_ID,
                        principalTable: "TRUCKS",
                        principalColumn: "ELEMENT_ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CONVOY_BACK_TRUCK_ID",
                table: "CONVOY",
                column: "BACK_TRUCK_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CONVOY_FRONT_TRUCK_ID",
                table: "CONVOY",
                column: "FRONT_TRUCK_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TRUCKS_ADDON_ID",
                table: "TRUCKS",
                column: "ADDON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WAGGONS_ADDON_ID",
                table: "WAGGONS",
                column: "ADDON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WAGGONS_TRUCK_ID",
                table: "WAGGONS",
                column: "TRUCK_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CONVOY");

            migrationBuilder.DropTable(
                name: "WAGGONS");

            migrationBuilder.DropTable(
                name: "TRUCKS");

            migrationBuilder.DropTable(
                name: "ADDONS");
        }
    }
}
