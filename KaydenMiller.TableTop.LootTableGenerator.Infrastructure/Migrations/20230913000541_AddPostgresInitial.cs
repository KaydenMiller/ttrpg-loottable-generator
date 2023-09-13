using System.Collections.Generic;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPostgresInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Descriptors",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    AvailableLootIds = table.Column<HashSet<LootId>>(type: "jsonb", nullable: false),
                    ModifierIds = table.Column<HashSet<ModifierId>>(type: "jsonb", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descriptors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Loot",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    AssignedTags = table.Column<List<string>>(type: "jsonb", nullable: false),
                    EquipmentId = table.Column<string>(type: "text", nullable: false),
                    MaxQuantity = table.Column<int>(type: "integer", nullable: false),
                    MinQuantity = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    RarityPercentage = table.Column<float>(type: "real", nullable: false, defaultValue: 0.5f)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loot", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LootTables",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    DescriptorIds = table.Column<List<DescriptorId>>(type: "jsonb", nullable: false),
                    ModifierIds = table.Column<List<ModifierId>>(type: "jsonb", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LootTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modifiers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    MaxQuantityModifier = table.Column<int>(type: "integer", nullable: false),
                    MinQuantityModifier = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    QuantityMultiplier = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modifiers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Descriptors");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Loot");

            migrationBuilder.DropTable(
                name: "LootTables");

            migrationBuilder.DropTable(
                name: "Modifiers");
        }
    }
}
