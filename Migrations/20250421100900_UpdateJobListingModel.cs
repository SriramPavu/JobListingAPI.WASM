using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobListingAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateJobListingModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "jobListingDetails",
                newName: "JobId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "jobListingDetails",
                newName: "Id");
        }
    }
}
