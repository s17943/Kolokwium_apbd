using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KolokwiumAPBD1.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    IdProject = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTeam = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.IdProject);
                });

            migrationBuilder.CreateTable(
                name: "TaskTypes",
                columns: table => new
                {
                    IdTaskType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTypes", x => x.IdTaskType);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    IdTeamMember = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.IdTeamMember);
                });

            migrationBuilder.CreateTable(
                name: "MyTasks",
                columns: table => new
                {
                    IdTask = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdTeam = table.Column<int>(type: "int", nullable: false),
                    IdTaskType = table.Column<int>(type: "int", nullable: false),
                    IdAssignedTo = table.Column<int>(type: "int", nullable: false),
                    IdCreator = table.Column<int>(type: "int", nullable: false),
                    ProjectIdProject = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyTasks", x => x.IdTask);
                    table.ForeignKey(
                        name: "FK_MyTasks_Projects_ProjectIdProject",
                        column: x => x.ProjectIdProject,
                        principalTable: "Projects",
                        principalColumn: "IdProject");
                });

            migrationBuilder.InsertData(
                table: "MyTasks",
                columns: new[] { "IdTask", "DateTime", "Description", "IdAssignedTo", "IdCreator", "IdTaskType", "IdTeam", "Name", "ProjectIdProject" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test task", 1, 1, 1, 1, "new task", null });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "IdProject", "Date", "IdTeam", "Name" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Projekt" });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "IdTeamMember", "Email", "FirstName", "LastName" },
                values: new object[] { 1, "email@wp.pl", "Andrzej", "Kowalski" });

            migrationBuilder.CreateIndex(
                name: "IX_MyTasks_ProjectIdProject",
                table: "MyTasks",
                column: "ProjectIdProject");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyTasks");

            migrationBuilder.DropTable(
                name: "TaskTypes");

            migrationBuilder.DropTable(
                name: "TeamMembers");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
