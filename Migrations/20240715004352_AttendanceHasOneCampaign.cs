using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetBot.Migrations
{
    /// <inheritdoc />
    public partial class AttendanceHasOneCampaign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Campaigns_CampaignsId",
                table: "Attendances");

            migrationBuilder.RenameColumn(
                name: "CampaignsId",
                table: "Attendances",
                newName: "CampaignId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendances_CampaignsId",
                table: "Attendances",
                newName: "IX_Attendances_CampaignId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Campaigns_CampaignId",
                table: "Attendances",
                column: "CampaignId",
                principalTable: "Campaigns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Campaigns_CampaignId",
                table: "Attendances");

            migrationBuilder.RenameColumn(
                name: "CampaignId",
                table: "Attendances",
                newName: "CampaignsId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendances_CampaignId",
                table: "Attendances",
                newName: "IX_Attendances_CampaignsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Campaigns_CampaignsId",
                table: "Attendances",
                column: "CampaignsId",
                principalTable: "Campaigns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
