using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HAN_API_CRUD.Migrations
{
    public partial class InitialEF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivePowerQ1Q4",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivePowerQ1Q4 = table.Column<double>(type: "float", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivePowerQ1Q4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivePowerQ2Q3",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivePowerQ2Q3 = table.Column<double>(type: "float", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivePowerQ2Q3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmpereIL1",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmpereIL1 = table.Column<double>(type: "float", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmpereIL1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmpereIL3",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmpereIL3 = table.Column<double>(type: "float", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmpereIL3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReactivePowerQ2Q3",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReactivePowerQ1Q2 = table.Column<double>(type: "float", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReactivePowerQ2Q3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReactivePowerQ3Q4",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReactivePowerQ3Q4 = table.Column<double>(type: "float", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReactivePowerQ3Q4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VoltUL1",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoltUL1 = table.Column<int>(type: "int", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoltUL1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VoltUL2",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoltUL2 = table.Column<int>(type: "int", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoltUL2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VoltUL3",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoltUL3 = table.Column<int>(type: "int", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoltUL3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HANData",
                columns: table => new
                {
                    HANId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTimePoll = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VersionIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivePowerQ1Q4Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivePowerQ2Q3Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReactivePowerQ1Q2Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReactivePowerQ3Q4Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmpereIL1Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmpereIL3Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoltUL1Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoltUL2Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoltUL3Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HANData", x => x.HANId);
                    table.ForeignKey(
                        name: "FK_HANData_ActivePowerQ1Q4_ActivePowerQ1Q4Id",
                        column: x => x.ActivePowerQ1Q4Id,
                        principalTable: "ActivePowerQ1Q4",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HANData_ActivePowerQ2Q3_ActivePowerQ2Q3Id",
                        column: x => x.ActivePowerQ2Q3Id,
                        principalTable: "ActivePowerQ2Q3",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HANData_AmpereIL1_AmpereIL1Id",
                        column: x => x.AmpereIL1Id,
                        principalTable: "AmpereIL1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HANData_AmpereIL3_AmpereIL3Id",
                        column: x => x.AmpereIL3Id,
                        principalTable: "AmpereIL3",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HANData_ReactivePowerQ2Q3_ReactivePowerQ1Q2Id",
                        column: x => x.ReactivePowerQ1Q2Id,
                        principalTable: "ReactivePowerQ2Q3",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HANData_ReactivePowerQ3Q4_ReactivePowerQ3Q4Id",
                        column: x => x.ReactivePowerQ3Q4Id,
                        principalTable: "ReactivePowerQ3Q4",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HANData_VoltUL1_VoltUL1Id",
                        column: x => x.VoltUL1Id,
                        principalTable: "VoltUL1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HANData_VoltUL2_VoltUL2Id",
                        column: x => x.VoltUL2Id,
                        principalTable: "VoltUL2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HANData_VoltUL3_VoltUL3Id",
                        column: x => x.VoltUL3Id,
                        principalTable: "VoltUL3",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HANData_ActivePowerQ1Q4Id",
                table: "HANData",
                column: "ActivePowerQ1Q4Id");

            migrationBuilder.CreateIndex(
                name: "IX_HANData_ActivePowerQ2Q3Id",
                table: "HANData",
                column: "ActivePowerQ2Q3Id");

            migrationBuilder.CreateIndex(
                name: "IX_HANData_AmpereIL1Id",
                table: "HANData",
                column: "AmpereIL1Id");

            migrationBuilder.CreateIndex(
                name: "IX_HANData_AmpereIL3Id",
                table: "HANData",
                column: "AmpereIL3Id");

            migrationBuilder.CreateIndex(
                name: "IX_HANData_ReactivePowerQ1Q2Id",
                table: "HANData",
                column: "ReactivePowerQ1Q2Id");

            migrationBuilder.CreateIndex(
                name: "IX_HANData_ReactivePowerQ3Q4Id",
                table: "HANData",
                column: "ReactivePowerQ3Q4Id");

            migrationBuilder.CreateIndex(
                name: "IX_HANData_VoltUL1Id",
                table: "HANData",
                column: "VoltUL1Id");

            migrationBuilder.CreateIndex(
                name: "IX_HANData_VoltUL2Id",
                table: "HANData",
                column: "VoltUL2Id");

            migrationBuilder.CreateIndex(
                name: "IX_HANData_VoltUL3Id",
                table: "HANData",
                column: "VoltUL3Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HANData");

            migrationBuilder.DropTable(
                name: "ActivePowerQ1Q4");

            migrationBuilder.DropTable(
                name: "ActivePowerQ2Q3");

            migrationBuilder.DropTable(
                name: "AmpereIL1");

            migrationBuilder.DropTable(
                name: "AmpereIL3");

            migrationBuilder.DropTable(
                name: "ReactivePowerQ2Q3");

            migrationBuilder.DropTable(
                name: "ReactivePowerQ3Q4");

            migrationBuilder.DropTable(
                name: "VoltUL1");

            migrationBuilder.DropTable(
                name: "VoltUL2");

            migrationBuilder.DropTable(
                name: "VoltUL3");
        }
    }
}
