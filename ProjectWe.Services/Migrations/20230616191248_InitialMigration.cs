using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectWe.Services.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2911)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(3001))
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(3263)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(3313))
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 712, DateTimeKind.Utc).AddTicks(90)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 712, DateTimeKind.Utc).AddTicks(172))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6537)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6642)),
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(3578)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(3635)),
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8382)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8452)),
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 712, DateTimeKind.Utc).AddTicks(461)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 712, DateTimeKind.Utc).AddTicks(518)),
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(5087)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(5180)),
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(2960)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(3072)),
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(1248)),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(1310)),
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
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(3036), null, "Civic engagement and participation" },
                    { 2, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(3038), null, "Volunteerism and community service" },
                    { 3, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(3039), null, "Youth development" },
                    { 4, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(3040), null, "Neighborhood revitalization" },
                    { 5, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(3040), null, "Interfaith and intercultural understanding" },
                    { 6, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(3041), null, "Aging and elder care" },
                    { 7, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(3042), null, "Food security and access" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(3347), "Sarajevo" },
                    { 2, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(3348), "Mostar" },
                    { 3, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(3349), "Banja Luka" },
                    { 4, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(3350), "Zenica" },
                    { 5, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(3350), "Tuzla" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "CreatedAt", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 16, 19, 12, 48, 712, DateTimeKind.Utc).AddTicks(209), null, "Submitted" },
                    { 2, new DateTime(2023, 6, 16, 19, 12, 48, 712, DateTimeKind.Utc).AddTicks(210), null, "Needs Improvment" },
                    { 3, new DateTime(2023, 6, 16, 19, 12, 48, 712, DateTimeKind.Utc).AddTicks(211), null, "Active" },
                    { 4, new DateTime(2023, 6, 16, 19, 12, 48, 712, DateTimeKind.Utc).AddTicks(212), null, "Completed" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "CategoryId", "CityId", "CreatedAt", "Description", "Name", "StatusId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(7995), "Project Description 1", "Project 1", 1, 2 },
                    { 2, 2, 1, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(7998), "Project Description 2", "Project 2", 2, 2 },
                    { 3, 3, 1, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8000), "Project Description 3", "Project 3", 3, 3 },
                    { 4, 4, 1, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8001), "Project Description 4", "Project 4", 2, 4 },
                    { 5, 5, 2, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8003), "Project Description 5", "Project 5", 1, 5 },
                    { 6, 6, 2, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8004), "Project Description 6", "Project 6", 2, 6 },
                    { 7, 7, 2, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8005), "Project Description 7", "Project 7", 3, 7 },
                    { 8, 1, 2, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8007), "Project Description 8", "Project 8", 2, 7 },
                    { 9, 2, 3, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8048), "Project Description 9", "Project 9", 1, 8 },
                    { 10, 3, 3, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8050), "Project Description 10", "Project 10", 2, 9 },
                    { 11, 4, 3, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8052), "Project Description 11", "Project 11", 3, 9 },
                    { 12, 5, 3, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8053), "Project Description 12", "Project 12", 1, 10 },
                    { 13, 6, 4, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8055), "Project Description 13", "Project 13", 1, 2 },
                    { 14, 7, 4, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8056), "Project Description 14", "Project 14", 1, 3 },
                    { 15, 1, 4, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8057), "Project Description 15", "Project 15", 2, 4 },
                    { 16, 2, 4, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8059), "Project Description 16", "Project 16", 3, 6 },
                    { 17, 2, 5, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8060), "Project Description 17", "Project 17", 3, 7 },
                    { 18, 3, 5, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8061), "Project Description 18", "Project 18", 3, 2 },
                    { 19, 4, 5, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8062), "Project Description 19", "Project 19", 4, 2 },
                    { 20, 5, 5, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(8064), "Project Description 20", "Project 20", 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Objectives",
                columns: new[] { "ObjectiveId", "CreatedAt", "Description", "ProjectId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4558), "Objective 1", 1, 2 },
                    { 2, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4560), "Objective 2", 2, 2 },
                    { 3, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4561), "Objective 3", 3, 3 },
                    { 4, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4562), "Objective 4", 4, 4 },
                    { 5, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4563), "Objective 5", 5, 5 },
                    { 6, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4564), "Objective 6", 6, 6 },
                    { 7, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4565), "Objective 7", 7, 7 },
                    { 8, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4565), "Objective 8", 8, 7 },
                    { 9, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4592), "Objective 9", 9, 8 },
                    { 10, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4593), "Objective 10", 10, 9 },
                    { 11, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4594), "Objective 11", 11, 9 },
                    { 12, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4595), "Objective 12", 12, 10 },
                    { 13, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4595), "Objective 13", 13, 2 },
                    { 14, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4596), "Objective 14", 14, 3 },
                    { 15, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4597), "Objective 15", 15, 4 },
                    { 16, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4598), "Objective 16", 16, 6 },
                    { 17, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4599), "Objective 17", 17, 7 },
                    { 18, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4599), "Objective 18", 18, 2 },
                    { 19, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4600), "Objective 19", 19, 2 },
                    { 20, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(4601), "Objective 20", 20, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "CreatedAt", "Description", "ProjectId", "StatusId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(9776), "Review 1", 1, 2, 1 },
                    { 2, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(9778), "Review 2", 2, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Votes",
                columns: new[] { "VoteId", "CreatedAt", "Positive", "ProjectId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 16, 19, 12, 48, 712, DateTimeKind.Utc).AddTicks(1210), true, 1, 1 },
                    { 2, new DateTime(2023, 6, 16, 19, 12, 48, 712, DateTimeKind.Utc).AddTicks(1212), true, 1, 2 },
                    { 3, new DateTime(2023, 6, 16, 19, 12, 48, 712, DateTimeKind.Utc).AddTicks(1213), true, 2, 1 },
                    { 4, new DateTime(2023, 6, 16, 19, 12, 48, 712, DateTimeKind.Utc).AddTicks(1213), false, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Outputs",
                columns: new[] { "OutputId", "CreatedAt", "Description", "Indicators", "MeansOfVerification", "ObjectiveId", "ProjectId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6208), "Output 1", null, null, 1, 1, 2 },
                    { 2, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6209), "Output 1", null, null, 1, 2, 2 },
                    { 3, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6211), "Output 1", null, null, 1, 3, 3 },
                    { 4, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6212), "Output 1", null, null, 1, 4, 4 },
                    { 5, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6212), "Output 1", null, null, 1, 5, 5 },
                    { 6, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6213), "Output 1", null, null, 1, 6, 6 },
                    { 7, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6214), "Output 1", null, null, 1, 7, 7 },
                    { 8, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6215), "Output 1", null, null, 1, 8, 7 },
                    { 9, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6216), "Output 1", null, null, 1, 9, 8 },
                    { 10, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6217), "Output 1", null, null, 1, 10, 9 },
                    { 11, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6218), "Output 1", null, null, 1, 11, 9 },
                    { 12, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6219), "Output 1", null, null, 1, 12, 10 },
                    { 13, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6220), "Output 1", null, null, 1, 13, 2 },
                    { 14, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6221), "Output 1", null, null, 1, 14, 3 },
                    { 15, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6222), "Output 1", null, null, 1, 15, 4 },
                    { 16, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6223), "Output 1", null, null, 1, 16, 6 },
                    { 17, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6223), "Output 1", null, null, 1, 17, 7 },
                    { 18, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6224), "Output 1", null, null, 1, 18, 2 },
                    { 19, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6225), "Output 1", null, null, 1, 19, 2 },
                    { 20, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(6226), "Output 1", null, null, 2, 20, 2 }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivityId", "CreatedAt", "Description", "DirectBeneficiaries", "EndDate", "IndirectBeneficiaries", "Locations", "OutputId", "ProjectId", "StartDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4468), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4468), null, null, 1, 1, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4467), 2 },
                    { 2, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4473), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4472), null, null, 2, 2, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4472), 2 },
                    { 3, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4474), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4474), null, null, 3, 3, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4474), 3 },
                    { 4, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4476), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4475), null, null, 4, 4, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4475), 4 },
                    { 5, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4477), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4477), null, null, 5, 5, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4477), 5 },
                    { 6, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4479), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4478), null, null, 6, 6, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4478), 6 },
                    { 7, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4480), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4480), null, null, 7, 7, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4479), 7 },
                    { 8, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4481), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4481), null, null, 8, 8, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4481), 7 },
                    { 9, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4482), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4482), null, null, 9, 9, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4482), 8 },
                    { 10, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4484), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4483), null, null, 10, 10, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4483), 9 },
                    { 11, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4485), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4485), null, null, 11, 11, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4484), 9 },
                    { 12, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4486), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4486), null, null, 12, 12, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4486), 10 },
                    { 13, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4487), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4487), null, null, 13, 13, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4487), 2 },
                    { 14, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4489), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4488), null, null, 14, 14, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4488), 3 },
                    { 15, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4490), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4490), null, null, 15, 15, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4489), 4 },
                    { 16, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4491), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4491), null, null, 16, 16, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4491), 6 },
                    { 17, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4492), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4492), null, null, 17, 17, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4492), 7 },
                    { 18, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4494), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4493), null, null, 18, 18, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4493), 2 },
                    { 19, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4495), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4495), null, null, 19, 19, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4494), 2 },
                    { 20, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4496), "Test", null, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4496), null, null, 20, 20, new DateTime(2023, 6, 16, 19, 12, 48, 710, DateTimeKind.Utc).AddTicks(4496), 2 }
                });

            migrationBuilder.InsertData(
                table: "Budgets",
                columns: new[] { "BudgetId", "ActivityId", "CostPerUnit", "CreatedAt", "Description", "NumberOfUnits", "ProjectId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2580), "Test", 0, 1, 2 },
                    { 2, 2, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2582), "Test", 0, 2, 2 },
                    { 3, 3, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2583), "Test", 0, 3, 3 },
                    { 4, 4, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2584), "Test", 0, 4, 4 },
                    { 5, 5, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2585), "Test", 0, 5, 5 },
                    { 6, 6, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2586), "Test", 0, 6, 6 },
                    { 7, 7, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2586), "Test", 0, 7, 7 },
                    { 8, 8, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2587), "Test", 0, 8, 7 },
                    { 9, 9, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2588), "Test", 0, 9, 8 },
                    { 10, 10, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2589), "Test", 0, 10, 9 },
                    { 11, 11, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2590), "Test", 0, 11, 9 },
                    { 12, 12, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2590), "Test", 0, 12, 10 },
                    { 13, 13, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2591), "Test", 0, 13, 2 },
                    { 14, 14, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2592), "Test", 0, 14, 3 },
                    { 15, 15, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2593), "Test", 0, 15, 4 },
                    { 16, 16, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2593), "Test", 0, 16, 6 },
                    { 17, 17, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2594), "Test", 0, 17, 7 },
                    { 18, 18, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2595), "Test", 0, 18, 2 },
                    { 19, 19, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2596), "Test", 0, 19, 2 },
                    { 20, 20, 0m, new DateTime(2023, 6, 16, 19, 12, 48, 711, DateTimeKind.Utc).AddTicks(2596), "Test", 0, 20, 2 }
                });

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
                name: "Budgets");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Votes");

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
        }
    }
}
