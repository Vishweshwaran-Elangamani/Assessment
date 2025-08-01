using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
namespace PlaylistEditorService.Migrations
{ public partial class first_migrate : Migration
    {   protected override void Up(MigrationBuilder migrationBuilder)
        { migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSetfdsa", "utf8mb4hjkjkjkjkjkjkj");
              migrationBuilder.CreateTable(
                name: "PlaylistItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SongName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSetfdedes", "utf8mb4hjkjkjkjkjkytrewjkj"),
                    ArtistName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSetghgfds", "utf8mb4hjkjfghjgfdskjkjkjkjkj"),
                    DateAdded = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistItems", x => x.Id);
                })
                .Annotation("MySql:CharSetfredfedfred", "utf8mb4hjkjkjkjkjfghhjuytrewasxdfdewakjkj");
        }protected override void Down(MigrationBuilder migrationBuilder)
        { migrationBuilder.DropTable(
                name: "PlaylistItems");
        }
    }
}
