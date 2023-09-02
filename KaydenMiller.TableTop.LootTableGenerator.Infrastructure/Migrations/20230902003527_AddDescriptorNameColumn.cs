using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptorNameColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Descriptors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Descriptors");
        }
    }
}
