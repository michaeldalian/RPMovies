using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesMovie.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyClient",
                columns: table => new
                {
                    MyClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    TotalRent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyClient", x => x.MyClientID);
                });

            migrationBuilder.CreateTable(
                name: "MyMovie",
                columns: table => new
                {
                    MyMovieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Genre = table.Column<string>(maxLength: 30, nullable: false),
                    Rating = table.Column<string>(maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyMovie", x => x.MyMovieID);
                });

            migrationBuilder.CreateTable(
                name: "MyMovieRent",
                columns: table => new
                {
                    MyMovieRentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MyClientID = table.Column<int>(nullable: false),
                    MyMovieID = table.Column<int>(nullable: false),
                    RentDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyMovieRent", x => x.MyMovieRentID);
                    table.ForeignKey(
                        name: "FK_MyMovieRent_MyClient_MyClientID",
                        column: x => x.MyClientID,
                        principalTable: "MyClient",
                        principalColumn: "MyClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyMovieRent_MyClientID",
                table: "MyMovieRent",
                column: "MyClientID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyMovie");

            migrationBuilder.DropTable(
                name: "MyMovieRent");

            migrationBuilder.DropTable(
                name: "MyClient");
        }
    }
}
