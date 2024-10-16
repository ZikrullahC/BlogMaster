using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c1ca9cda-aecb-4507-97ad-8f463e69d09d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c6a0faa1-8b80-493e-94c5-8e36e28a9a4c"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("a877bbd4-f537-42a4-bd30-4cfe91c50889"), new Guid("3d072495-4c20-46cf-a307-e3650f903bd3"), "Learn What You Can Do with Spring Boot\r\nSpring Boot offers a fast way to build applications. It looks at your classpath and at the beans you have configured, makes reasonable assumptions about what you are missing, and adds those items. With Spring Boot, you can focus more on business features and less on infrastructure.\r\n\r\nThe following examples show what Spring Boot can do for you:\r\n\r\nIs Spring MVC on the classpath? There are several specific beans you almost always need, and Spring Boot adds them automatically. A Spring MVC application also needs a servlet container, so Spring Boot automatically configures embedded Tomcat.\r\n\r\nIs Jetty on the classpath? If so, you probably do NOT want Tomcat but instead want embedded Jetty. Spring Boot handles that for you.\r\n\r\nIs Thymeleaf on the classpath? If so, there are a few beans that must always be added to your application context. Spring Boot adds them for you.\r\n\r\nThese are just a few examples of the automatic configuration Spring Boot provides. At the same time, Spring Boot does not get in your way. For example, if Thymeleaf is on your path, Spring Boot automatically adds a SpringTemplateEngine to your application context. But if you define your own SpringTemplateEngine with your own settings, Spring Boot does not add one. This leaves you in control with little effort on your part.", "Admin Test", new DateTime(2024, 10, 16, 17, 34, 29, 69, DateTimeKind.Local).AddTicks(6944), null, null, new Guid("8092a603-4ac8-42b6-8dd6-b4297dc37ebc"), false, null, null, "Building an Application with Spring Boot", 15 },
                    { new Guid("d9bdc6aa-1ab2-4bc2-ac08-6dd075004fc9"), new Guid("fa44c043-fa75-43e3-b43c-159bf33861cf"), "ASP.NET Core, a powerful and open-source framework from Microsoft, provides a superb foundation for building efficient and scalable backends.\r\n\r\nIn this blog series, we’ll be constructing a comprehensive Courses API. This API will serve as a central hub for retrieving information about courses and their instructors, laying the groundwork for a dynamic web application.\r\n\r\nWelcome to the first blog of this exciting series! Today, we’ll dive into the essentials of ASP.NET Core and build a simple, yet functional, Course API.\r\n\r\nWhy ASP.NET Core?\r\nHere’s why ASP.NET Core is a compelling choice for crafting your backend systems:\r\n\r\nCross-platform — Develop and run your backends on Windows, Linux, or macOS.\r\nPerformance — ASP.NET Core consistently ranks among the fastest web frameworks, giving your applications an edge.\r\nFlexibility — Its modular design allows you to pick and choose the exact components you need, reducing overhead.\r\nStrong Community and Support — Backed by Microsoft and a large community, you’ll find plenty of resources and help when needed.\r\nModern Tooling — Works seamlessly with popular development tools like Visual Studio and Visual Studio Code.\r\nWhat We’ll Cover\r\nIn this blog post, we’ll guide you through the essentials of building a backend with ASP.NET Core. Get ready to dive into…\r\n\r\nSetting up your development environment\r\nCreating your first ASP.NET Core web API project\r\nImplementing basic CRUD operations (Create, Read, Update, Delete)", "Admin Test", new DateTime(2024, 10, 16, 17, 34, 29, 69, DateTimeKind.Local).AddTicks(6933), null, null, new Guid("642b90c3-6a72-4225-8ab6-f0c800d457b3"), false, null, null, "Build a Backend with ASP.NET Core — Beginner Guide", 15 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("acbd2027-d44c-4ad9-82a1-0663e938700c"), "83e58cca-acf6-4ab7-a693-3964618b6b7c", "Admin", "ADMIN" },
                    { new Guid("da3fe45e-4430-4e90-8b2c-640ca8f9c067"), "c7193b88-e884-4e68-9f69-e37cee93da19", "User", "USER" },
                    { new Guid("dc7fffe4-9e29-4d4e-9986-11684c1ebcd7"), "ac83993f-7fd1-4489-ab28-f2fe22393522", "Superadmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("bc17922c-11f6-4993-8e63-e9d7255acda5"), 0, "927c1d07-a0d4-4ccd-a713-19a98eba9d14", null, false, "Ali", "Veli", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEGsAfZCIl8UHA1Y6fim7EVVqAz5uiIZVbpc/ILDfSdSQuHQLeRbtEWw6rOrudjUxUw==", "+90457853543", false, "9b1c1244-ac84-4484-94dc-90105ca5a429", false, "admin@gmail.com" },
                    { new Guid("e220b1cc-7f5b-47c7-96f4-01af756fbd9f"), 0, "5af3e9c9-ac54-4a8c-8d12-997e56052e6c", null, true, "Cem", "Keskin", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEITFDmBMhxT7ftJ5Pn764z1lHFzl3upWNzBKxgdlHguBZ7zpoaI4dSbQLntX8jtjpQ==", "+90453453543", true, "98dd8431-a48e-47d7-b10b-5bc6462bdd84", false, "superadmin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d072495-4c20-46cf-a307-e3650f903bd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 17, 34, 29, 69, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa44c043-fa75-43e3-b43c-159bf33861cf"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 17, 34, 29, 69, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("642b90c3-6a72-4225-8ab6-f0c800d457b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 17, 34, 29, 70, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8092a603-4ac8-42b6-8dd6-b4297dc37ebc"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 17, 34, 29, 70, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("acbd2027-d44c-4ad9-82a1-0663e938700c"), new Guid("bc17922c-11f6-4993-8e63-e9d7255acda5") },
                    { new Guid("dc7fffe4-9e29-4d4e-9986-11684c1ebcd7"), new Guid("e220b1cc-7f5b-47c7-96f4-01af756fbd9f") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a877bbd4-f537-42a4-bd30-4cfe91c50889"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d9bdc6aa-1ab2-4bc2-ac08-6dd075004fc9"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("c1ca9cda-aecb-4507-97ad-8f463e69d09d"), new Guid("fa44c043-fa75-43e3-b43c-159bf33861cf"), "ASP.NET Core, a powerful and open-source framework from Microsoft, provides a superb foundation for building efficient and scalable backends.\r\n\r\nIn this blog series, we’ll be constructing a comprehensive Courses API. This API will serve as a central hub for retrieving information about courses and their instructors, laying the groundwork for a dynamic web application.\r\n\r\nWelcome to the first blog of this exciting series! Today, we’ll dive into the essentials of ASP.NET Core and build a simple, yet functional, Course API.\r\n\r\nWhy ASP.NET Core?\r\nHere’s why ASP.NET Core is a compelling choice for crafting your backend systems:\r\n\r\nCross-platform — Develop and run your backends on Windows, Linux, or macOS.\r\nPerformance — ASP.NET Core consistently ranks among the fastest web frameworks, giving your applications an edge.\r\nFlexibility — Its modular design allows you to pick and choose the exact components you need, reducing overhead.\r\nStrong Community and Support — Backed by Microsoft and a large community, you’ll find plenty of resources and help when needed.\r\nModern Tooling — Works seamlessly with popular development tools like Visual Studio and Visual Studio Code.\r\nWhat We’ll Cover\r\nIn this blog post, we’ll guide you through the essentials of building a backend with ASP.NET Core. Get ready to dive into…\r\n\r\nSetting up your development environment\r\nCreating your first ASP.NET Core web API project\r\nImplementing basic CRUD operations (Create, Read, Update, Delete)", "Admin Test", new DateTime(2024, 10, 16, 9, 33, 14, 51, DateTimeKind.Local).AddTicks(2023), null, null, new Guid("642b90c3-6a72-4225-8ab6-f0c800d457b3"), false, null, null, "Build a Backend with ASP.NET Core — Beginner Guide", 15 },
                    { new Guid("c6a0faa1-8b80-493e-94c5-8e36e28a9a4c"), new Guid("3d072495-4c20-46cf-a307-e3650f903bd3"), "Learn What You Can Do with Spring Boot\r\nSpring Boot offers a fast way to build applications. It looks at your classpath and at the beans you have configured, makes reasonable assumptions about what you are missing, and adds those items. With Spring Boot, you can focus more on business features and less on infrastructure.\r\n\r\nThe following examples show what Spring Boot can do for you:\r\n\r\nIs Spring MVC on the classpath? There are several specific beans you almost always need, and Spring Boot adds them automatically. A Spring MVC application also needs a servlet container, so Spring Boot automatically configures embedded Tomcat.\r\n\r\nIs Jetty on the classpath? If so, you probably do NOT want Tomcat but instead want embedded Jetty. Spring Boot handles that for you.\r\n\r\nIs Thymeleaf on the classpath? If so, there are a few beans that must always be added to your application context. Spring Boot adds them for you.\r\n\r\nThese are just a few examples of the automatic configuration Spring Boot provides. At the same time, Spring Boot does not get in your way. For example, if Thymeleaf is on your path, Spring Boot automatically adds a SpringTemplateEngine to your application context. But if you define your own SpringTemplateEngine with your own settings, Spring Boot does not add one. This leaves you in control with little effort on your part.", "Admin Test", new DateTime(2024, 10, 16, 9, 33, 14, 51, DateTimeKind.Local).AddTicks(2033), null, null, new Guid("8092a603-4ac8-42b6-8dd6-b4297dc37ebc"), false, null, null, "Building an Application with Spring Boot", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d072495-4c20-46cf-a307-e3650f903bd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 9, 33, 14, 51, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa44c043-fa75-43e3-b43c-159bf33861cf"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 9, 33, 14, 51, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("642b90c3-6a72-4225-8ab6-f0c800d457b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 9, 33, 14, 51, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8092a603-4ac8-42b6-8dd6-b4297dc37ebc"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 9, 33, 14, 51, DateTimeKind.Local).AddTicks(5465));
        }
    }
}
