using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddLootRarityPercent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "RarityPercentage",
                table: "Loot",
                type: "REAL",
                nullable: false,
                defaultValue: 0.5f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RarityPercentage",
                table: "Loot");
        }
    }
}
