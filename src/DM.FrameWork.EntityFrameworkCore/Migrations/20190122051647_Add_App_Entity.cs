using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DM.FrameWork.Migrations
{
    public partial class Add_App_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId1",
                table: "AbpEntityPropertyChanges");

            migrationBuilder.DropIndex(
                name: "IX_AbpEntityPropertyChanges_EntityChangeId1",
                table: "AbpEntityPropertyChanges");

            migrationBuilder.DropColumn(
                name: "EntityChangeId1",
                table: "AbpEntityPropertyChanges");

            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    App_Name = table.Column<string>(nullable: true),
                    App_Remark = table.Column<string>(nullable: true),
                    App_IsHide = table.Column<bool>(nullable: false),
                    App_Icon = table.Column<string>(nullable: true),
                    App_Parent = table.Column<Guid>(nullable: false),
                    App_HasChild = table.Column<bool>(nullable: false),
                    App_Level = table.Column<decimal>(nullable: false),
                    App_Url = table.Column<string>(nullable: true),
                    App_Sort = table.Column<string>(nullable: true),
                    App_Type = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.AddColumn<Guid>(
                name: "EntityChangeId1",
                table: "AbpEntityPropertyChanges",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityPropertyChanges_EntityChangeId1",
                table: "AbpEntityPropertyChanges",
                column: "EntityChangeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId1",
                table: "AbpEntityPropertyChanges",
                column: "EntityChangeId1",
                principalTable: "AbpEntityChanges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
