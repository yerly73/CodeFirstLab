using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstLab.Migrations
{
    /// <inheritdoc />
    public partial class v1_addcolumnactive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Students",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Students");
        }
    }
}
