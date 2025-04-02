using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateAuthorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ActivationTime",
                table: "Authors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActivationUserId",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "Authors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedUserId",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedTime",
                table: "Authors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertedUserId",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Authors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Authors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "Authors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdateUserId",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "UpdateTime", "UpdateUserId" },
                values: new object[] { null, null, null, null, null, null, false, false, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivationTime",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "ActivationUserId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "InsertedTime",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "InsertedUserId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Authors");
        }
    }
}
