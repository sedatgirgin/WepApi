using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class ContextUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "variables",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Decimal",
                table: "variables",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Delta",
                table: "variables",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DetailId",
                table: "variables",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeviceModel",
                table: "variables",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Imageoff",
                table: "variables",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Imageon",
                table: "variables",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Inserttime",
                table: "variables",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Isactive",
                table: "variables",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Iscancelled",
                table: "variables",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ishaccp",
                table: "variables",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Islogic",
                table: "variables",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Isonchange",
                table: "variables",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Lastupdate",
                table: "variables",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "variables",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Maximum",
                table: "variables",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Measureunit",
                table: "variables",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Minimum",
                table: "variables",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "variables",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReadWrite",
                table: "variables",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Signed",
                table: "variables",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ToDisplay",
                table: "variables",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Varencoding",
                table: "variables",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Decimal",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "Delta",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "DetailId",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "DeviceModel",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "Imageoff",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "Imageon",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "Inserttime",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "Isactive",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "Iscancelled",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "Ishaccp",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "Islogic",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "Isonchange",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "Lastupdate",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "Maximum",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "Measureunit",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "Minimum",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "ReadWrite",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "Signed",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "ToDisplay",
                table: "variables");

            migrationBuilder.DropColumn(
                name: "Varencoding",
                table: "variables");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "variables",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
