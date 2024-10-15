using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("3d072495-4c20-46cf-a307-e3650f903bd3"), "Admin Test", new DateTime(2024, 10, 15, 15, 55, 37, 457, DateTimeKind.Local).AddTicks(9403), null, null, false, null, null, "ASP.NET Core" },
                    { new Guid("fa44c043-fa75-43e3-b43c-159bf33861cf"), "Admin Test", new DateTime(2024, 10, 15, 15, 55, 37, 457, DateTimeKind.Local).AddTicks(9385), null, null, false, null, null, "Spring Boot" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("642b90c3-6a72-4225-8ab6-f0c800d457b3"), "Admin Test", new DateTime(2024, 10, 15, 15, 55, 37, 458, DateTimeKind.Local).AddTicks(1722), null, null, "images/springImage", "jpg", false, null, null },
                    { new Guid("8092a603-4ac8-42b6-8dd6-b4297dc37ebc"), "Admin Test", new DateTime(2024, 10, 15, 15, 55, 37, 458, DateTimeKind.Local).AddTicks(1711), null, null, "images/testImage", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("11e6bf5f-f634-4314-86e5-210d1523284c"), new Guid("3d072495-4c20-46cf-a307-e3650f903bd3"), "Learn What You Can Do with Spring Boot\r\nSpring Boot offers a fast way to build applications. It looks at your classpath and at the beans you have configured, makes reasonable assumptions about what you are missing, and adds those items. With Spring Boot, you can focus more on business features and less on infrastructure.\r\n\r\nThe following examples show what Spring Boot can do for you:\r\n\r\nIs Spring MVC on the classpath? There are several specific beans you almost always need, and Spring Boot adds them automatically. A Spring MVC application also needs a servlet container, so Spring Boot automatically configures embedded Tomcat.\r\n\r\nIs Jetty on the classpath? If so, you probably do NOT want Tomcat but instead want embedded Jetty. Spring Boot handles that for you.\r\n\r\nIs Thymeleaf on the classpath? If so, there are a few beans that must always be added to your application context. Spring Boot adds them for you.\r\n\r\nThese are just a few examples of the automatic configuration Spring Boot provides. At the same time, Spring Boot does not get in your way. For example, if Thymeleaf is on your path, Spring Boot automatically adds a SpringTemplateEngine to your application context. But if you define your own SpringTemplateEngine with your own settings, Spring Boot does not add one. This leaves you in control with little effort on your part.", "Admin Test", new DateTime(2024, 10, 15, 15, 55, 37, 457, DateTimeKind.Local).AddTicks(6744), null, null, new Guid("8092a603-4ac8-42b6-8dd6-b4297dc37ebc"), false, null, null, "Building an Application with Spring Boot", 15 },
                    { new Guid("63a2f034-a28d-4a39-9e6d-d3496aad5de8"), new Guid("fa44c043-fa75-43e3-b43c-159bf33861cf"), "ASP.NET Core, a powerful and open-source framework from Microsoft, provides a superb foundation for building efficient and scalable backends.\r\n\r\nIn this blog series, we’ll be constructing a comprehensive Courses API. This API will serve as a central hub for retrieving information about courses and their instructors, laying the groundwork for a dynamic web application.\r\n\r\nWelcome to the first blog of this exciting series! Today, we’ll dive into the essentials of ASP.NET Core and build a simple, yet functional, Course API.\r\n\r\nWhy ASP.NET Core?\r\nHere’s why ASP.NET Core is a compelling choice for crafting your backend systems:\r\n\r\nCross-platform — Develop and run your backends on Windows, Linux, or macOS.\r\nPerformance — ASP.NET Core consistently ranks among the fastest web frameworks, giving your applications an edge.\r\nFlexibility — Its modular design allows you to pick and choose the exact components you need, reducing overhead.\r\nStrong Community and Support — Backed by Microsoft and a large community, you’ll find plenty of resources and help when needed.\r\nModern Tooling — Works seamlessly with popular development tools like Visual Studio and Visual Studio Code.\r\nWhat We’ll Cover\r\nIn this blog post, we’ll guide you through the essentials of building a backend with ASP.NET Core. Get ready to dive into…\r\n\r\nSetting up your development environment\r\nCreating your first ASP.NET Core web API project\r\nImplementing basic CRUD operations (Create, Read, Update, Delete)", "Admin Test", new DateTime(2024, 10, 15, 15, 55, 37, 457, DateTimeKind.Local).AddTicks(6708), null, null, new Guid("642b90c3-6a72-4225-8ab6-f0c800d457b3"), false, null, null, "Build a Backend with ASP.NET Core — Beginner Guide", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("11e6bf5f-f634-4314-86e5-210d1523284c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("63a2f034-a28d-4a39-9e6d-d3496aad5de8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d072495-4c20-46cf-a307-e3650f903bd3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa44c043-fa75-43e3-b43c-159bf33861cf"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("642b90c3-6a72-4225-8ab6-f0c800d457b3"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8092a603-4ac8-42b6-8dd6-b4297dc37ebc"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
