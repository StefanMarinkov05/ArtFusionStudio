using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtFusionStudio.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddValidationForAllFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_DisplayTechnologies_CameraId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Memory_CameraId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_StorageCapacities_CameraId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "WirelessChargingSupported",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "USBs",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Protection",
                table: "ProtectionLevels",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<decimal>(
                name: "OSVersion",
                table: "OperatingSystemVersions",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)");

            migrationBuilder.AlterColumn<string>(
                name: "OSName",
                table: "OperatingSystems",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "DisplayTechnologies",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DiscountCode",
                table: "Coupons",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CaseTypes",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CaseMaterials",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DisplayTechnologyId",
                table: "Products",
                column: "DisplayTechnologyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MemoryId",
                table: "Products",
                column: "MemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StorageCapacityId",
                table: "Products",
                column: "StorageCapacityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_DisplayTechnologies_DisplayTechnologyId",
                table: "Products",
                column: "DisplayTechnologyId",
                principalTable: "DisplayTechnologies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Memory_MemoryId",
                table: "Products",
                column: "MemoryId",
                principalTable: "Memory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_StorageCapacities_StorageCapacityId",
                table: "Products",
                column: "StorageCapacityId",
                principalTable: "StorageCapacities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_DisplayTechnologies_DisplayTechnologyId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Memory_MemoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_StorageCapacities_StorageCapacityId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_DisplayTechnologyId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_MemoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_StorageCapacityId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "USBs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Protection",
                table: "ProtectionLevels",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AddColumn<bool>(
                name: "WirelessChargingSupported",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OSVersion",
                table: "OperatingSystemVersions",
                type: "decimal(2,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "OSName",
                table: "OperatingSystems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "DisplayTechnologies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "DiscountCode",
                table: "Coupons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CaseTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CaseMaterials",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_DisplayTechnologies_CameraId",
                table: "Products",
                column: "CameraId",
                principalTable: "DisplayTechnologies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Memory_CameraId",
                table: "Products",
                column: "CameraId",
                principalTable: "Memory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_StorageCapacities_CameraId",
                table: "Products",
                column: "CameraId",
                principalTable: "StorageCapacities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
