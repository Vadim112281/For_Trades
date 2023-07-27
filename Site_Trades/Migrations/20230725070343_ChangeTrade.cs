using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Site_Trades.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Marzha",
                table: "Trades",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Marzha",
                table: "Trades");
        }
    }
}
