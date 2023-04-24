using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Interview.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Interviewers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(30)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(30)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviewers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterviewFeedBacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewFeedBacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterviewTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "varchar(300)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recruiters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(30)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(30)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recruiters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AInterviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecruiterId = table.Column<int>(type: "int", nullable: false),
                    SubmissionId = table.Column<int>(type: "int", nullable: false),
                    InterviewTypeId = table.Column<int>(type: "int", nullable: false),
                    InterviewRound = table.Column<int>(type: "int", nullable: false),
                    ScheduledOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InterviewerId = table.Column<int>(type: "int", nullable: false),
                    FeedBackId = table.Column<int>(type: "int", nullable: false),
                    interviewFeedBackId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AInterviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AInterviews_InterviewFeedBacks_interviewFeedBackId",
                        column: x => x.interviewFeedBackId,
                        principalTable: "InterviewFeedBacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AInterviews_InterviewTypes_InterviewTypeId",
                        column: x => x.InterviewTypeId,
                        principalTable: "InterviewTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AInterviews_Interviewers_InterviewerId",
                        column: x => x.InterviewerId,
                        principalTable: "Interviewers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AInterviews_Recruiters_RecruiterId",
                        column: x => x.RecruiterId,
                        principalTable: "Recruiters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AInterviews_InterviewerId",
                table: "AInterviews",
                column: "InterviewerId");

            migrationBuilder.CreateIndex(
                name: "IX_AInterviews_interviewFeedBackId",
                table: "AInterviews",
                column: "interviewFeedBackId");

            migrationBuilder.CreateIndex(
                name: "IX_AInterviews_InterviewTypeId",
                table: "AInterviews",
                column: "InterviewTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AInterviews_RecruiterId",
                table: "AInterviews",
                column: "RecruiterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AInterviews");

            migrationBuilder.DropTable(
                name: "InterviewFeedBacks");

            migrationBuilder.DropTable(
                name: "InterviewTypes");

            migrationBuilder.DropTable(
                name: "Interviewers");

            migrationBuilder.DropTable(
                name: "Recruiters");
        }
    }
}
