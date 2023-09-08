using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddLootTags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssignedTags",
                table: "Loot",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedTags",
                table: "Loot");
        }
    }
}
