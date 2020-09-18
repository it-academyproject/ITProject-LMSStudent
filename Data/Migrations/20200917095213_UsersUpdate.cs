using Microsoft.EntityFrameworkCore.Migrations;

namespace LMSStudent.Data.Migrations
{
    public partial class UsersUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_Resources_ResourceId",
                table: "Exercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Topics_TopicId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachingMaterials_Resources_ResourceId",
                table: "TeachingMaterials");

            migrationBuilder.AlterColumn<int>(
                name: "ResourceId",
                table: "TeachingMaterials",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TopicId",
                table: "Resources",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ResourceId",
                table: "Exercises",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_Resources_ResourceId",
                table: "Exercises",
                column: "ResourceId",
                principalTable: "Resources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Topics_TopicId",
                table: "Resources",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeachingMaterials_Resources_ResourceId",
                table: "TeachingMaterials",
                column: "ResourceId",
                principalTable: "Resources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_Resources_ResourceId",
                table: "Exercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Topics_TopicId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachingMaterials_Resources_ResourceId",
                table: "TeachingMaterials");

            migrationBuilder.AlterColumn<int>(
                name: "ResourceId",
                table: "TeachingMaterials",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "TopicId",
                table: "Resources",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ResourceId",
                table: "Exercises",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_Resources_ResourceId",
                table: "Exercises",
                column: "ResourceId",
                principalTable: "Resources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Topics_TopicId",
                table: "Resources",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeachingMaterials_Resources_ResourceId",
                table: "TeachingMaterials",
                column: "ResourceId",
                principalTable: "Resources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
