using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e5d941ef-a589-4da3-ad6b-4db91386f0df"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f5f7b386-bac9-430d-8a2b-4bc03884d013"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("39b82acb-448f-4c7c-a494-c8a96afb5fe8"), new Guid("fa44c043-fa75-43e3-b43c-159bf33861cf"), "ASP.NET Core, a powerful and open-source framework from Microsoft, provides a superb foundation for building efficient and scalable backends.\r\n\r\nIn this blog series, we’ll be constructing a comprehensive Courses API. This API will serve as a central hub for retrieving information about courses and their instructors, laying the groundwork for a dynamic web application.\r\n\r\nWelcome to the first blog of this exciting series! Today, we’ll dive into the essentials of ASP.NET Core and build a simple, yet functional, Course API.\r\n\r\nWhy ASP.NET Core?\r\nHere’s why ASP.NET Core is a compelling choice for crafting your backend systems:\r\n\r\nCross-platform — Develop and run your backends on Windows, Linux, or macOS.\r\nPerformance — ASP.NET Core consistently ranks among the fastest web frameworks, giving your applications an edge.\r\nFlexibility — Its modular design allows you to pick and choose the exact components you need, reducing overhead.\r\nStrong Community and Support — Backed by Microsoft and a large community, you’ll find plenty of resources and help when needed.\r\nModern Tooling — Works seamlessly with popular development tools like Visual Studio and Visual Studio Code.\r\nWhat We’ll Cover\r\nIn this blog post, we’ll guide you through the essentials of building a backend with ASP.NET Core. Get ready to dive into…\r\n\r\nSetting up your development environment\r\nCreating your first ASP.NET Core web API project\r\nImplementing basic CRUD operations (Create, Read, Update, Delete)", "Admin Test", new DateTime(2024, 10, 26, 12, 26, 18, 856, DateTimeKind.Local).AddTicks(4215), null, null, new Guid("642b90c3-6a72-4225-8ab6-f0c800d457b3"), false, null, null, "Build a Backend with ASP.NET Core — Beginner Guide", new Guid("e220b1cc-7f5b-47c7-96f4-01af756fbd9f"), 15 },
                    { new Guid("a96d3a56-1323-4783-8c13-c7181b0390df"), new Guid("3d072495-4c20-46cf-a307-e3650f903bd3"), "Learn What You Can Do with Spring Boot\r\nSpring Boot offers a fast way to build applications. It looks at your classpath and at the beans you have configured, makes reasonable assumptions about what you are missing, and adds those items. With Spring Boot, you can focus more on business features and less on infrastructure.\r\n\r\nThe following examples show what Spring Boot can do for you:\r\n\r\nIs Spring MVC on the classpath? There are several specific beans you almost always need, and Spring Boot adds them automatically. A Spring MVC application also needs a servlet container, so Spring Boot automatically configures embedded Tomcat.\r\n\r\nIs Jetty on the classpath? If so, you probably do NOT want Tomcat but instead want embedded Jetty. Spring Boot handles that for you.\r\n\r\nIs Thymeleaf on the classpath? If so, there are a few beans that must always be added to your application context. Spring Boot adds them for you.\r\n\r\nThese are just a few examples of the automatic configuration Spring Boot provides. At the same time, Spring Boot does not get in your way. For example, if Thymeleaf is on your path, Spring Boot automatically adds a SpringTemplateEngine to your application context. But if you define your own SpringTemplateEngine with your own settings, Spring Boot does not add one. This leaves you in control with little effort on your part.", "Admin Test", new DateTime(2024, 10, 26, 12, 26, 18, 856, DateTimeKind.Local).AddTicks(4226), null, null, new Guid("8092a603-4ac8-42b6-8dd6-b4297dc37ebc"), false, null, null, "Building an Application with Spring Boot", new Guid("bc17922c-11f6-4993-8e63-e9d7255acda5"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("acbd2027-d44c-4ad9-82a1-0663e938700c"),
                column: "ConcurrencyStamp",
                value: "ae0c4769-a1b9-4c75-adf1-c022aea6726d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("da3fe45e-4430-4e90-8b2c-640ca8f9c067"),
                column: "ConcurrencyStamp",
                value: "400d2104-3b22-44ab-8b94-53882756788c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("dc7fffe4-9e29-4d4e-9986-11684c1ebcd7"),
                column: "ConcurrencyStamp",
                value: "a42cf8a8-e7f7-4f94-ad52-08acd6cfad94");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc17922c-11f6-4993-8e63-e9d7255acda5"),
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86958430-ff4c-4ce9-9883-6df9468163e8", "superadmin@gmail.com", "AQAAAAIAAYagAAAAELGXfLdrPcMP1lO9MvS2zRNUMtc7QJnT2+4H45yGzQfOkNEmHyU7x2lV744CP6+roA==", "147cb9ff-e52d-46e7-adfd-52b246d74739" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e220b1cc-7f5b-47c7-96f4-01af756fbd9f"),
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91c4d6dd-6749-41fe-8487-c1bb481eb051", "superadmin@gmail.com", "AQAAAAIAAYagAAAAEBvQqCC6wugjRGzciOswbXNMceT32rUqdRWcnGB7ExnvfSloZz/LNWxP9P4h2fiqPw==", "f80bc0fc-5914-424d-89f6-4737d8cab840" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d072495-4c20-46cf-a307-e3650f903bd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 26, 12, 26, 18, 856, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa44c043-fa75-43e3-b43c-159bf33861cf"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 26, 12, 26, 18, 856, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("642b90c3-6a72-4225-8ab6-f0c800d457b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 26, 12, 26, 18, 856, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8092a603-4ac8-42b6-8dd6-b4297dc37ebc"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 26, 12, 26, 18, 856, DateTimeKind.Local).AddTicks(7753));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("39b82acb-448f-4c7c-a494-c8a96afb5fe8"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a96d3a56-1323-4783-8c13-c7181b0390df"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("e5d941ef-a589-4da3-ad6b-4db91386f0df"), new Guid("3d072495-4c20-46cf-a307-e3650f903bd3"), "Learn What You Can Do with Spring Boot\r\nSpring Boot offers a fast way to build applications. It looks at your classpath and at the beans you have configured, makes reasonable assumptions about what you are missing, and adds those items. With Spring Boot, you can focus more on business features and less on infrastructure.\r\n\r\nThe following examples show what Spring Boot can do for you:\r\n\r\nIs Spring MVC on the classpath? There are several specific beans you almost always need, and Spring Boot adds them automatically. A Spring MVC application also needs a servlet container, so Spring Boot automatically configures embedded Tomcat.\r\n\r\nIs Jetty on the classpath? If so, you probably do NOT want Tomcat but instead want embedded Jetty. Spring Boot handles that for you.\r\n\r\nIs Thymeleaf on the classpath? If so, there are a few beans that must always be added to your application context. Spring Boot adds them for you.\r\n\r\nThese are just a few examples of the automatic configuration Spring Boot provides. At the same time, Spring Boot does not get in your way. For example, if Thymeleaf is on your path, Spring Boot automatically adds a SpringTemplateEngine to your application context. But if you define your own SpringTemplateEngine with your own settings, Spring Boot does not add one. This leaves you in control with little effort on your part.", "Admin Test", new DateTime(2024, 10, 17, 13, 23, 48, 882, DateTimeKind.Local).AddTicks(3839), null, null, new Guid("8092a603-4ac8-42b6-8dd6-b4297dc37ebc"), false, null, null, "Building an Application with Spring Boot", new Guid("bc17922c-11f6-4993-8e63-e9d7255acda5"), 15 },
                    { new Guid("f5f7b386-bac9-430d-8a2b-4bc03884d013"), new Guid("fa44c043-fa75-43e3-b43c-159bf33861cf"), "ASP.NET Core, a powerful and open-source framework from Microsoft, provides a superb foundation for building efficient and scalable backends.\r\n\r\nIn this blog series, we’ll be constructing a comprehensive Courses API. This API will serve as a central hub for retrieving information about courses and their instructors, laying the groundwork for a dynamic web application.\r\n\r\nWelcome to the first blog of this exciting series! Today, we’ll dive into the essentials of ASP.NET Core and build a simple, yet functional, Course API.\r\n\r\nWhy ASP.NET Core?\r\nHere’s why ASP.NET Core is a compelling choice for crafting your backend systems:\r\n\r\nCross-platform — Develop and run your backends on Windows, Linux, or macOS.\r\nPerformance — ASP.NET Core consistently ranks among the fastest web frameworks, giving your applications an edge.\r\nFlexibility — Its modular design allows you to pick and choose the exact components you need, reducing overhead.\r\nStrong Community and Support — Backed by Microsoft and a large community, you’ll find plenty of resources and help when needed.\r\nModern Tooling — Works seamlessly with popular development tools like Visual Studio and Visual Studio Code.\r\nWhat We’ll Cover\r\nIn this blog post, we’ll guide you through the essentials of building a backend with ASP.NET Core. Get ready to dive into…\r\n\r\nSetting up your development environment\r\nCreating your first ASP.NET Core web API project\r\nImplementing basic CRUD operations (Create, Read, Update, Delete)", "Admin Test", new DateTime(2024, 10, 17, 13, 23, 48, 882, DateTimeKind.Local).AddTicks(3826), null, null, new Guid("642b90c3-6a72-4225-8ab6-f0c800d457b3"), false, null, null, "Build a Backend with ASP.NET Core — Beginner Guide", new Guid("e220b1cc-7f5b-47c7-96f4-01af756fbd9f"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("acbd2027-d44c-4ad9-82a1-0663e938700c"),
                column: "ConcurrencyStamp",
                value: "2c03f7e9-4733-465e-8eb9-6e1cb0d49b49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("da3fe45e-4430-4e90-8b2c-640ca8f9c067"),
                column: "ConcurrencyStamp",
                value: "eb9d7e24-3b75-4012-9076-15333cd76ae0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("dc7fffe4-9e29-4d4e-9986-11684c1ebcd7"),
                column: "ConcurrencyStamp",
                value: "ab74880b-4624-480a-8c7e-62d55832edf8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc17922c-11f6-4993-8e63-e9d7255acda5"),
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "795c8480-7835-4d2d-b233-f34150f6d326", null, "AQAAAAIAAYagAAAAEDYFDkrMbRtSwjSb6hJ9FAjI/Ij4XsYIpC7WfBzHb6QDCVaP9EnCmhTMqcE2Jm8FqQ==", "ad314fb8-0c57-4003-ba71-89587b3972d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e220b1cc-7f5b-47c7-96f4-01af756fbd9f"),
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a78f234-ae45-48a6-aeb7-772fa09064bb", null, "AQAAAAIAAYagAAAAEBqCaP+rLRw6hWkmmCa8gVzxDQvHT0U3adpx9TdldtTgAxn78PM3UTk3iNpxR8rq5Q==", "162a64aa-b10b-457e-9b9e-f3b2c4ac8ff3" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d072495-4c20-46cf-a307-e3650f903bd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 17, 13, 23, 48, 882, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa44c043-fa75-43e3-b43c-159bf33861cf"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 17, 13, 23, 48, 882, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("642b90c3-6a72-4225-8ab6-f0c800d457b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 17, 13, 23, 48, 882, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8092a603-4ac8-42b6-8dd6-b4297dc37ebc"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 17, 13, 23, 48, 882, DateTimeKind.Local).AddTicks(7432));
        }
    }
}
