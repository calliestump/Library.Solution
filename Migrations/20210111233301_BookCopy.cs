using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class BookCopy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentRole",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "CheckedOut",
                table: "Copies",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "BookCopy",
                columns: table => new
                {
                    BookCopyId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<int>(nullable: false),
                    CopyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCopy", x => x.BookCopyId);
                    table.ForeignKey(
                        name: "FK_BookCopy_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCopy_Copies_CopyId",
                        column: x => x.CopyId,
                        principalTable: "Copies",
                        principalColumn: "CopyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patron",
                columns: table => new
                {
                    PatronId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PatronName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patron", x => x.PatronId);
                    table.ForeignKey(
                        name: "FK_Patron_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CheckedOuts",
                columns: table => new
                {
                    CheckedOutId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CopyId = table.Column<int>(nullable: false),
                    PatronId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckedOuts", x => x.CheckedOutId);
                    table.ForeignKey(
                        name: "FK_CheckedOuts_Copies_CopyId",
                        column: x => x.CopyId,
                        principalTable: "Copies",
                        principalColumn: "CopyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckedOuts_Patron_PatronId",
                        column: x => x.PatronId,
                        principalTable: "Patron",
                        principalColumn: "PatronId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookCopy_BookId",
                table: "BookCopy",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCopy_CopyId",
                table: "BookCopy",
                column: "CopyId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckedOuts_CopyId",
                table: "CheckedOuts",
                column: "CopyId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckedOuts_PatronId",
                table: "CheckedOuts",
                column: "PatronId");

            migrationBuilder.CreateIndex(
                name: "IX_Patron_UserId",
                table: "Patron",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCopy");

            migrationBuilder.DropTable(
                name: "CheckedOuts");

            migrationBuilder.DropTable(
                name: "Patron");

            migrationBuilder.DropColumn(
                name: "CheckedOut",
                table: "Copies");

            migrationBuilder.AddColumn<string>(
                name: "IdentRole",
                table: "AspNetUsers",
                nullable: true);
        }
    }
}
