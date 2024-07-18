using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace route_Tsak.Migrations
{
    /// <inheritdoc />
    public partial class fixenumerror : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "paymentenum",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "statusenum",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "paymentenum",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "statusenum",
                table: "Orders");
        }
    }
}
