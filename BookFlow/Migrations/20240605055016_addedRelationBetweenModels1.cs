using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookFlow.Migrations
{
    /// <inheritdoc />
    public partial class addedRelationBetweenModels1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Books");
        }
    }
}
