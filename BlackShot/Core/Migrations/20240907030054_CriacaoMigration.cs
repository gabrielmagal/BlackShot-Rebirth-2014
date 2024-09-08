using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Core.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterInfoModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AccountNumber = table.Column<Guid>(type: "uuid", nullable: false),
                    CharacterID = table.Column<long>(type: "bigint", nullable: false),
                    Nickname = table.Column<string>(type: "character varying(17)", maxLength: 17, nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    Hero = table.Column<byte>(type: "smallint", nullable: false),
                    Experience = table.Column<long>(type: "bigint", nullable: false),
                    BountyPoints = table.Column<long>(type: "bigint", nullable: false),
                    Kills = table.Column<long>(type: "bigint", nullable: false),
                    Deaths = table.Column<long>(type: "bigint", nullable: false),
                    Wins = table.Column<long>(type: "bigint", nullable: false),
                    Losses = table.Column<int>(type: "integer", nullable: false),
                    ClanName = table.Column<string>(type: "character varying(17)", maxLength: 17, nullable: true),
                    ClanMark = table.Column<long>(type: "bigint", nullable: false),
                    SkinColor = table.Column<byte>(type: "smallint", nullable: false),
                    PlayerCash = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterInfoModel", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterInfoModel");
        }
    }
}
