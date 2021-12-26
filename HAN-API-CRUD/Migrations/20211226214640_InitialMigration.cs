using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HAN_API_CRUD.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "activePowerQ1Q4Object",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    activePowerQ1Q4 = table.Column<double>(type: "float", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_activePowerQ1Q4Object", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "activePowerQ2Q3Object",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    activePowerQ2Q3 = table.Column<double>(type: "float", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_activePowerQ2Q3Object", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ampereIL1Object",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ampereIL1 = table.Column<double>(type: "float", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ampereIL1Object", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ampereIL3Object",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ampereIL3 = table.Column<double>(type: "float", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ampereIL3Object", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "reactivePowerQ1Q2Object",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    reactivePowerQ1Q2 = table.Column<double>(type: "float", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reactivePowerQ1Q2Object", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "reactivePowerQ3Q4Object",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    reactivePowerQ3Q4 = table.Column<double>(type: "float", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reactivePowerQ3Q4Object", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "voltUL1Object",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    voltUL1 = table.Column<int>(type: "int", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voltUL1Object", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "voltUL2Object",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    voltUL2 = table.Column<int>(type: "int", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voltUL2Object", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "voltUL3Object",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    voltUL3 = table.Column<int>(type: "int", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voltUL3Object", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HANData",
                columns: table => new
                {
                    HANId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dateTimePoll = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    versionIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modelID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activePowerQ1Q4Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    activePowerQ2Q3Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    reactivePowerQ1Q2Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    reactivePowerQ3Q4Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ampereIL1Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ampereIL3Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    voltUL1Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    voltUL2Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    voltUL3Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HANData", x => x.HANId);
                    table.ForeignKey(
                        name: "FK_HANData_activePowerQ1Q4Object_activePowerQ1Q4Id",
                        column: x => x.activePowerQ1Q4Id,
                        principalTable: "activePowerQ1Q4Object",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HANData_activePowerQ2Q3Object_activePowerQ2Q3Id",
                        column: x => x.activePowerQ2Q3Id,
                        principalTable: "activePowerQ2Q3Object",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HANData_ampereIL1Object_ampereIL1Id",
                        column: x => x.ampereIL1Id,
                        principalTable: "ampereIL1Object",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HANData_ampereIL3Object_ampereIL3Id",
                        column: x => x.ampereIL3Id,
                        principalTable: "ampereIL3Object",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HANData_reactivePowerQ1Q2Object_reactivePowerQ1Q2Id",
                        column: x => x.reactivePowerQ1Q2Id,
                        principalTable: "reactivePowerQ1Q2Object",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HANData_reactivePowerQ3Q4Object_reactivePowerQ3Q4Id",
                        column: x => x.reactivePowerQ3Q4Id,
                        principalTable: "reactivePowerQ3Q4Object",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HANData_voltUL1Object_voltUL1Id",
                        column: x => x.voltUL1Id,
                        principalTable: "voltUL1Object",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HANData_voltUL2Object_voltUL2Id",
                        column: x => x.voltUL2Id,
                        principalTable: "voltUL2Object",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HANData_voltUL3Object_voltUL3Id",
                        column: x => x.voltUL3Id,
                        principalTable: "voltUL3Object",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HANData_activePowerQ1Q4Id",
                table: "HANData",
                column: "activePowerQ1Q4Id");

            migrationBuilder.CreateIndex(
                name: "IX_HANData_activePowerQ2Q3Id",
                table: "HANData",
                column: "activePowerQ2Q3Id");

            migrationBuilder.CreateIndex(
                name: "IX_HANData_ampereIL1Id",
                table: "HANData",
                column: "ampereIL1Id");

            migrationBuilder.CreateIndex(
                name: "IX_HANData_ampereIL3Id",
                table: "HANData",
                column: "ampereIL3Id");

            migrationBuilder.CreateIndex(
                name: "IX_HANData_reactivePowerQ1Q2Id",
                table: "HANData",
                column: "reactivePowerQ1Q2Id");

            migrationBuilder.CreateIndex(
                name: "IX_HANData_reactivePowerQ3Q4Id",
                table: "HANData",
                column: "reactivePowerQ3Q4Id");

            migrationBuilder.CreateIndex(
                name: "IX_HANData_voltUL1Id",
                table: "HANData",
                column: "voltUL1Id");

            migrationBuilder.CreateIndex(
                name: "IX_HANData_voltUL2Id",
                table: "HANData",
                column: "voltUL2Id");

            migrationBuilder.CreateIndex(
                name: "IX_HANData_voltUL3Id",
                table: "HANData",
                column: "voltUL3Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HANData");

            migrationBuilder.DropTable(
                name: "activePowerQ1Q4Object");

            migrationBuilder.DropTable(
                name: "activePowerQ2Q3Object");

            migrationBuilder.DropTable(
                name: "ampereIL1Object");

            migrationBuilder.DropTable(
                name: "ampereIL3Object");

            migrationBuilder.DropTable(
                name: "reactivePowerQ1Q2Object");

            migrationBuilder.DropTable(
                name: "reactivePowerQ3Q4Object");

            migrationBuilder.DropTable(
                name: "voltUL1Object");

            migrationBuilder.DropTable(
                name: "voltUL2Object");

            migrationBuilder.DropTable(
                name: "voltUL3Object");
        }
    }
}
