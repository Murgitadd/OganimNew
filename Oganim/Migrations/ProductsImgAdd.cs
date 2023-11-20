using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OganiMigrations
{
    public partial class addImageLgURLintoProdutstable : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageLgURL",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

    }
}
