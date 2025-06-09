using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ESys.Db.PostgreSQL.TenantSlave
{
    public partial class v002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentAudit");

            migrationBuilder.DropTable(
                name: "RoleAudit");

            migrationBuilder.DropTable(
                name: "RolePermissionAudit");

            migrationBuilder.DropTable(
                name: "UserRoleAudit");

            migrationBuilder.CreateTable(
                name: "Workmanip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    CreateBy = table.Column<int>(type: "integer", nullable: false),
                    UpdateBy = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workmanip", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceState",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    RunState = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    WorkmanipId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceState", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceState_Workmanip_WorkmanipId",
                        column: x => x.WorkmanipId,
                        principalTable: "Workmanip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkmanipData1",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OutletPoolFlow = table.Column<double>(type: "double precision", nullable: true),
                    OutletPoolLiquidLevel = table.Column<double>(type: "double precision", nullable: true),
                    OutletPoolResidualChlorine = table.Column<double>(type: "double precision", nullable: true),
                    RegulationPoolLiftPump1 = table.Column<int>(type: "integer", nullable: true),
                    RegulationPoolLiftPump2 = table.Column<int>(type: "integer", nullable: true),
                    RegulationPoolLiquidLevel = table.Column<double>(type: "double precision", nullable: true),
                    RegulationPoolLowLiquidLevel = table.Column<bool>(type: "boolean", nullable: true),
                    RegulationPoolHighLiquidLevel = table.Column<bool>(type: "boolean", nullable: true),
                    RegulationPoolMiddleLiquidLevel = table.Column<bool>(type: "boolean", nullable: true),
                    SumpSubmersiblePump1 = table.Column<int>(type: "integer", nullable: true),
                    SumpSubmersiblePump2 = table.Column<int>(type: "integer", nullable: true),
                    DrugDosage = table.Column<double>(type: "double precision", nullable: true),
                    StirringAerationFan = table.Column<int>(type: "integer", nullable: true),
                    DischargePump1 = table.Column<int>(type: "integer", nullable: true),
                    DischargePump2 = table.Column<int>(type: "integer", nullable: true),
                    BioChemicalPoolAerationFan1 = table.Column<int>(type: "integer", nullable: true),
                    BioChemicalPoolAerationFan2 = table.Column<int>(type: "integer", nullable: true),
                    SludgePoolFeedPump = table.Column<int>(type: "integer", nullable: true),
                    SludgePoolLiquidLevel = table.Column<double>(type: "double precision", nullable: true),
                    SludgePoolLowLiquidLevel = table.Column<bool>(type: "boolean", nullable: true),
                    SludgePoolHighLiquidLevel = table.Column<bool>(type: "boolean", nullable: true),
                    SludgePoolMiddleLiquidLevel = table.Column<bool>(type: "boolean", nullable: true),
                    SludgeReturnPump1 = table.Column<int>(type: "integer", nullable: true),
                    SludgeReturnPump2 = table.Column<int>(type: "integer", nullable: true),
                    DisinfectionPoolLowLiquidLevel = table.Column<bool>(type: "boolean", nullable: true),
                    DisinfectionPoolHighLiquidLevel = table.Column<bool>(type: "boolean", nullable: true),
                    DisinfectionPoolMiddleLiquidLevel = table.Column<bool>(type: "boolean", nullable: true),
                    DisinfectantMeteringPump1 = table.Column<int>(type: "integer", nullable: true),
                    DisinfectantMeteringPump2 = table.Column<int>(type: "integer", nullable: true),
                    DisinfectionBlenderOperation = table.Column<int>(type: "integer", nullable: true),
                    TestValue = table.Column<int>(type: "integer", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    WorkmanipId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkmanipData1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkmanipData1_Workmanip_WorkmanipId",
                        column: x => x.WorkmanipId,
                        principalTable: "Workmanip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeviceState_Name",
                table: "DeviceState",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceState_WorkmanipId",
                table: "DeviceState",
                column: "WorkmanipId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkmanipData1_Date",
                table: "WorkmanipData1",
                column: "Date");

            migrationBuilder.CreateIndex(
                name: "IX_WorkmanipData1_WorkmanipId",
                table: "WorkmanipData1",
                column: "WorkmanipId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviceState");

            migrationBuilder.DropTable(
                name: "WorkmanipData1");

            migrationBuilder.DropTable(
                name: "Workmanip");

            migrationBuilder.CreateTable(
                name: "DepartmentAudit",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Action = table.Column<byte>(type: "smallint", nullable: false),
                    AuditTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: true),
                    CreateBy = table.Column<int>(type: "integer", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    EntityId = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    ManagerId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ParentId = table.Column<int>(type: "integer", nullable: true),
                    UpdateBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleAudit",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Action = table.Column<byte>(type: "smallint", nullable: false),
                    AuditTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreateBy = table.Column<int>(type: "integer", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    EntityId = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsHidden = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    UpdateBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissionAudit",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Action = table.Column<byte>(type: "smallint", nullable: false),
                    AuditTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreateBy = table.Column<int>(type: "integer", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    EntityId = table.Column<int>(type: "integer", nullable: false),
                    PermissionId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    UpdateBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissionAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoleAudit",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Action = table.Column<byte>(type: "smallint", nullable: false),
                    AuditTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreateBy = table.Column<int>(type: "integer", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    EntityId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    UpdateBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleAudit", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentAudit_EntityId",
                table: "DepartmentAudit",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAudit_EntityId",
                table: "RoleAudit",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissionAudit_EntityId",
                table: "RolePermissionAudit",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleAudit_EntityId",
                table: "UserRoleAudit",
                column: "EntityId");
        }
    }
}
