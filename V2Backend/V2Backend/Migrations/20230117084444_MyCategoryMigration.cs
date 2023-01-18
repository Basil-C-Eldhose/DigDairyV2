using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace V2Backend.Migrations
{
    /// <inheritdoc />
    public partial class MyCategoryMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblcategory",
                columns: table => new
                {
                    cid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblcategory", x => x.cid);
                });

            migrationBuilder.CreateTable(
                name: "tblexpense",
                columns: table => new
                {
                    eid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblexpense", x => x.eid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblcategory");

            migrationBuilder.DropTable(
                name: "tblexpense");
        }
    }
}
