using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Build a Backend with ASP.NET Core — Beginner Guide",
                Content = "ASP.NET Core, a powerful and open-source framework from Microsoft, provides a superb foundation for building efficient and scalable backends.\r\n\r\nIn this blog series, we’ll be constructing a comprehensive Courses API. This API will serve as a central hub for retrieving information about courses and their instructors, laying the groundwork for a dynamic web application.\r\n\r\nWelcome to the first blog of this exciting series! Today, we’ll dive into the essentials of ASP.NET Core and build a simple, yet functional, Course API.\r\n\r\nWhy ASP.NET Core?\r\nHere’s why ASP.NET Core is a compelling choice for crafting your backend systems:\r\n\r\nCross-platform — Develop and run your backends on Windows, Linux, or macOS.\r\nPerformance — ASP.NET Core consistently ranks among the fastest web frameworks, giving your applications an edge.\r\nFlexibility — Its modular design allows you to pick and choose the exact components you need, reducing overhead.\r\nStrong Community and Support — Backed by Microsoft and a large community, you’ll find plenty of resources and help when needed.\r\nModern Tooling — Works seamlessly with popular development tools like Visual Studio and Visual Studio Code.\r\nWhat We’ll Cover\r\nIn this blog post, we’ll guide you through the essentials of building a backend with ASP.NET Core. Get ready to dive into…\r\n\r\nSetting up your development environment\r\nCreating your first ASP.NET Core web API project\r\nImplementing basic CRUD operations (Create, Read, Update, Delete)",
                ViewCount = 15,
                CategoryId = Guid.Parse("FA44C043-FA75-43E3-B43C-159BF33861CF"),
                ImageId = Guid.Parse("642B90C3-6A72-4225-8AB6-F0C800D457B3"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Building an Application with Spring Boot",
                Content = "Learn What You Can Do with Spring Boot\r\nSpring Boot offers a fast way to build applications. It looks at your classpath and at the beans you have configured, makes reasonable assumptions about what you are missing, and adds those items. With Spring Boot, you can focus more on business features and less on infrastructure.\r\n\r\nThe following examples show what Spring Boot can do for you:\r\n\r\nIs Spring MVC on the classpath? There are several specific beans you almost always need, and Spring Boot adds them automatically. A Spring MVC application also needs a servlet container, so Spring Boot automatically configures embedded Tomcat.\r\n\r\nIs Jetty on the classpath? If so, you probably do NOT want Tomcat but instead want embedded Jetty. Spring Boot handles that for you.\r\n\r\nIs Thymeleaf on the classpath? If so, there are a few beans that must always be added to your application context. Spring Boot adds them for you.\r\n\r\nThese are just a few examples of the automatic configuration Spring Boot provides. At the same time, Spring Boot does not get in your way. For example, if Thymeleaf is on your path, Spring Boot automatically adds a SpringTemplateEngine to your application context. But if you define your own SpringTemplateEngine with your own settings, Spring Boot does not add one. This leaves you in control with little effort on your part.",
                ViewCount = 15,
                CategoryId = Guid.Parse("3D072495-4C20-46CF-A307-E3650F903BD3"),    
                ImageId = Guid.Parse("8092A603-4AC8-42B6-8DD6-B4297DC37EBC"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });
        }
    }
}
