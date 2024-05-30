using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PicturePath = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    MiddleName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: false),
                    Arrived = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Token = table.Column<string>(type: "text", nullable: false),
                    Expires = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Galleries",
                columns: new[] { "Id", "Created", "Name", "PicturePath", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(1854), "Работа 1", "Files//Images//GalleryPictures//1.jpg", null },
                    { 2, new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(1860), "Работа 2", "Files//Images//GalleryPictures//2.jpg", null },
                    { 3, new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(1861), "Работа 3", "Files//Images//GalleryPictures//3.jpg", null },
                    { 4, new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(1862), "Работа 4", "Files//Images//GalleryPictures//4.jpg", null },
                    { 5, new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(1863), "Работа 5", "Files//Images//GalleryPictures//5.jpg", null },
                    { 6, new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(1867), "Работа 6", "Files//Images//GalleryPictures//6.jpg", null },
                    { 7, new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(1868), "Работа 7", "Files//Images//GalleryPictures//7.jpg", null },
                    { 8, new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(1869), "Работа 8", "Files//Images//GalleryPictures//8.jpg", null },
                    { 9, new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(1870), "Работа 9", "Files//Images//GalleryPictures//9.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(9736), "Guest", null },
                    { 2, new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(9758), "Operator", null },
                    { 3, new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(9762), "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "MiddleName", "PasswordHash", "PhoneNumber", "RoleId", "Updated" },
                values: new object[,]
                {
                    { new Guid("3c96c3d4-7ef0-43d7-ab2e-df0e302aa0c3"), new DateTime(2024, 5, 29, 22, 1, 48, 666, DateTimeKind.Utc).AddTicks(2013), "samatoperator@gmail.com", "Даниил", "Устюшкин", "Оператор", "$2a$11$3uZjkeDa5l8Ws8isGXTjSe6Qrsyg0dIlOfr37PlHZH4hAG6UAWC9G", "+791234567891", 2, null },
                    { new Guid("5da9f4ab-52bd-4a6d-8a08-ef5423bc1815"), new DateTime(2024, 5, 29, 22, 1, 48, 815, DateTimeKind.Utc).AddTicks(5300), "samatadmin@gmail.com", "Даниил", "Устюшкин", "Админ", "$2a$11$O4349GFBbmTmzY.2MnS5Tuio1fOf8gMaqFSmWEhwHbhRcWOOaW3.2", "+791234567892", 3, null },
                    { new Guid("5e8ed760-6bce-464e-b8da-bba6780afdcb"), new DateTime(2024, 5, 29, 22, 1, 48, 518, DateTimeKind.Utc).AddTicks(6368), "samatguest@gmail.com", "Самат", "Хасипов", "Гость", "$2a$11$64MMqSwa3TBL/5kvn9toMe52Ik8jbnRoV1Y0A5ewuP0e8F6.dRxS6", "+791234567890", 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Galleries_Name",
                table: "Galleries",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_UserId",
                table: "Sessions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PhoneNumber",
                table: "Users",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
