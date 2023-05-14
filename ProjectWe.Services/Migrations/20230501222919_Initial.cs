using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectWe.Services.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(1098)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(1246)),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(7483)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(7591)),
                    UserName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", maxLength: 4096, nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(185)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(272))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(600)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(704))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(8060)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(8138))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AppRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(1667)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(1770))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AppUserRoles_AspNetUserRoles_UserId_RoleId",
                        columns: x => new { x.UserId, x.RoleId },
                        principalTable: "AspNetUserRoles",
                        principalColumns: new[] { "UserId", "RoleId" });
                    table.ForeignKey(
                        name: "FK_AppUserRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppUserRoles_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(4074)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(4166)),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                    table.ForeignKey(
                        name: "FK_Projects_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId");
                    table.ForeignKey(
                        name: "FK_Projects_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId");
                    table.ForeignKey(
                        name: "FK_Projects_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Objectives",
                columns: table => new
                {
                    ObjectiveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(1049)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(1124)),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objectives", x => x.ObjectiveId);
                    table.ForeignKey(
                        name: "FK_Objective_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                    table.ForeignKey(
                        name: "FK_Objective_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(6390)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(6483)),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                    table.ForeignKey(
                        name: "FK_Reviews_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId");
                    table.ForeignKey(
                        name: "FK_Reviews_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    VoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Positive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(8472)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(8548)),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.VoteId);
                    table.ForeignKey(
                        name: "FK_Votes_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                    table.ForeignKey(
                        name: "FK_Votes_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Outputs",
                columns: table => new
                {
                    OutputId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Indicators = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    MeansOfVerification = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(2367)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(2459)),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ObjectiveId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outputs", x => x.OutputId);
                    table.ForeignKey(
                        name: "FK_Outputs_ObjectiveId",
                        column: x => x.ObjectiveId,
                        principalTable: "Objectives",
                        principalColumn: "ObjectiveId");
                    table.ForeignKey(
                        name: "FK_Outputs_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                    table.ForeignKey(
                        name: "FK_Outputs_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Locations = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DirectBeneficiaries = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    IndirectBeneficiaries = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 381, DateTimeKind.Utc).AddTicks(8361)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 381, DateTimeKind.Utc).AddTicks(8510)),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    OutputId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_Activity__OutputId",
                        column: x => x.OutputId,
                        principalTable: "Outputs",
                        principalColumn: "OutputId");
                    table.ForeignKey(
                        name: "FK_Activity_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                    table.ForeignKey(
                        name: "FK_Activity_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    BudgetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    CostPerUnit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NumberOfUnits = table.Column<int>(type: "int", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true, computedColumnSql: "([CostPerUnit]*[NumberOfUnits])", stored: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(8206)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(8289)),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.BudgetId);
                    table.ForeignKey(
                        name: "FK_Budgets__ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "ActivityId");
                    table.ForeignKey(
                        name: "FK_Budgets_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                    table.ForeignKey(
                        name: "FK_Budgets_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "079e2914-753a-4c3f-b8d0-8f368fd2a50d", new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(1343), "Admin", "ADMIN" },
                    { 2, "79e72872-f936-49d9-96bb-9f38c52f7d0b", new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(1348), "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[,]
                {
                    { 1, "0b275a23-24e7-4bbc-86c5-5f24843d0062", new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(7667), "admin@email.com", true, "Admin", "Super", null, "ADMIN@EMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEJSnLX1fQLSM0GHZgeHn7+BQiABcmmD5rMhOu5DCTCHh3huSn3kevRq8fmUQJ0urqg==", null, "VHFSXSTATK7ARJ7NGKNMU2TOAEL6GDZU", "Admin" },
                    { 2, "0b275a23-24e7-4bbc-86c5-5f24843d0062", new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(7687), "manager@email.com", true, "Manager", "Super", null, "MANAGER@EMAIL.COM", "MANAGER", "AQAAAAEAACcQAAAAEJSnLX1fQLSM0GHZgeHn7+BQiABcmmD5rMhOu5DCTCHh3huSn3kevRq8fmUQJ0urqg==", null, "VHFSXSTATK7ARJ7NGKNMU2TOAEL6GDZU", "Manager" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(352), null, "Civic engagement and participation" },
                    { 2, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(354), null, "Volunteerism and community service" },
                    { 3, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(355), null, "Youth development" },
                    { 4, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(356), null, "Neighborhood revitalization" },
                    { 5, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(357), null, "Interfaith and intercultural understanding" },
                    { 6, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(358), null, "Aging and elder care" },
                    { 7, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(359), null, "Food security and access" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(750), "Sarajevo" },
                    { 2, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(752), "Mostar" },
                    { 3, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(753), "Banja Luka" },
                    { 4, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(754), "Zenica" },
                    { 5, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(755), "Tuzla" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "CreatedAt", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(8184), null, "Submitted" },
                    { 2, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(8187), null, "Needs Improvment" },
                    { 3, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(8188), null, "Active" },
                    { 4, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(8189), null, "Completed" }
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId", "CreatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(5463) },
                    { 2, 1, new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(5466) },
                    { 2, 2, new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(5469) }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "CategoryId", "CityId", "CreatedAt", "Description", "Name", "StatusId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(6037), "Project Description 1", "Project 1", 3, 1 },
                    { 2, 2, 2, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(6042), "Project Description 2", "Project 2", 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Objectives",
                columns: new[] { "ObjectiveId", "CreatedAt", "Description", "ProjectId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(1974), "Objective 1", 1, 2 },
                    { 2, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(1976), "Objective 1", 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "CreatedAt", "Description", "ProjectId", "StatusId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(7740), "Review 1", 1, 2, 1 },
                    { 2, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(7743), "Review 2", 2, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Votes",
                columns: new[] { "VoteId", "CreatedAt", "Positive", "ProjectId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(9352), true, 1, 1 },
                    { 2, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(9354), true, 1, 2 },
                    { 3, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(9355), true, 2, 1 },
                    { 4, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(9356), false, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Outputs",
                columns: new[] { "OutputId", "CreatedAt", "Description", "Indicators", "MeansOfVerification", "ObjectiveId", "ProjectId", "UserId" },
                values: new object[] { 1, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(3740), "Output 1", null, null, 1, 1, 2 });

            migrationBuilder.InsertData(
                table: "Outputs",
                columns: new[] { "OutputId", "CreatedAt", "Description", "Indicators", "MeansOfVerification", "ObjectiveId", "ProjectId", "UserId" },
                values: new object[] { 2, new DateTime(2023, 5, 1, 22, 29, 19, 383, DateTimeKind.Utc).AddTicks(3743), "Output 1", null, null, 2, 1, 2 });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivityId", "CreatedAt", "Description", "DirectBeneficiaries", "EndDate", "IndirectBeneficiaries", "Locations", "OutputId", "ProjectId", "StartDate", "UserId" },
                values: new object[] { 1, new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(311), "Test", null, new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(310), null, null, 1, 1, new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(309), 2 });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivityId", "CreatedAt", "Description", "DirectBeneficiaries", "EndDate", "IndirectBeneficiaries", "Locations", "OutputId", "ProjectId", "StartDate", "UserId" },
                values: new object[] { 2, new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(318), "Test", null, new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(318), null, null, 1, 1, new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(317), 2 });

            migrationBuilder.InsertData(
                table: "Budgets",
                columns: new[] { "BudgetId", "ActivityId", "CostPerUnit", "CreatedAt", "Description", "NumberOfUnits", "ProjectId", "UserId" },
                values: new object[] { 1, 1, 0m, new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(9810), "Test", 0, 1, 2 });

            migrationBuilder.InsertData(
                table: "Budgets",
                columns: new[] { "BudgetId", "ActivityId", "CostPerUnit", "CreatedAt", "Description", "NumberOfUnits", "ProjectId", "UserId" },
                values: new object[] { 2, 1, 0m, new DateTime(2023, 5, 1, 22, 29, 19, 382, DateTimeKind.Utc).AddTicks(9813), "Test", 0, 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_OutputId",
                table: "Activities",
                column: "OutputId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_ProjectId",
                table: "Activities",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_UserId",
                table: "Activities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AppRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRoles_RoleId",
                table: "AppUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AppUsers",
                column: "NormalizedEmail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_Email",
                table: "AppUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_UserName",
                table: "AppUsers",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AppUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_ActivityId",
                table: "Budgets",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_ProjectId",
                table: "Budgets",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_UserId",
                table: "Budgets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Objectives_ProjectId",
                table: "Objectives",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Objectives_UserId",
                table: "Objectives",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Outputs_ObjectiveId",
                table: "Outputs",
                column: "ObjectiveId");

            migrationBuilder.CreateIndex(
                name: "IX_Outputs_ProjectId",
                table: "Outputs",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Outputs_UserId",
                table: "Outputs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CategoryId",
                table: "Projects",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CityId",
                table: "Projects",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_StatusId",
                table: "Projects",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProjectId",
                table: "Reviews",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_StatusId",
                table: "Reviews",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_ProjectId",
                table: "Votes",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_UserId",
                table: "Votes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Budgets");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Outputs");

            migrationBuilder.DropTable(
                name: "Objectives");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "AppUsers");
        }
    }
}
