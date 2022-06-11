using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentManagement.Infrastructure.Migrations
{
    public partial class CreateAdvertsmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adverts",
                columns: table => new
                {
                    AdvartID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descriptions = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AdvertEmail = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    AvailableDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adverts", x => x.AdvartID);
                    table.ForeignKey(
                        name: "FK_Adverts_Cities_CID",
                        column: x => x.CID,
                        principalTable: "Cities",
                        principalColumn: "CID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_CID",
                table: "Adverts",
                column: "CID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adverts");
        }
    }
}
