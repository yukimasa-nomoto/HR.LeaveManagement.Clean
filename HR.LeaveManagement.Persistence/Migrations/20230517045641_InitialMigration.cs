﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    DefaultDays = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveAllocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NumberOfDays = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Period = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    EmployeeId = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveAllocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LA_LT_LTI",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    StartDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    RequestComments = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Approved = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    Cancelled = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LR_LT_LTI",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LeaveTypes",
                columns: new[] { "Id", "DateCreated", "DateModified", "DefaultDays", "Name" },
                values: new object[] { 1, new DateTime(2023, 5, 17, 13, 56, 41, 372, DateTimeKind.Local).AddTicks(9793), new DateTime(2023, 5, 17, 13, 56, 41, 372, DateTimeKind.Local).AddTicks(9808), 10, "Vacation" });

            migrationBuilder.CreateIndex(
                name: "IX_LA_LTI",
                table: "LeaveAllocations",
                column: "LeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LR_LTI",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveAllocations");

            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.DropTable(
                name: "LeaveTypes");
        }
    }
}
