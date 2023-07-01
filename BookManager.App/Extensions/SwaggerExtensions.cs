using System.Reflection;
using Microsoft.OpenApi.Models;

namespace BookManager.Extensions;

public static class SwaggerExtensions
{
    public static IServiceCollection AddSwaggerDoc(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo()
            {
                Title = "Book Manager",
                Description = "API to manage books that you are currently reading or intend to read.",
                Version = "v1",
                Contact = new OpenApiContact
                {
                    Name = "Gabriel Vasconcellos",
                    Email = "gavapim@gmail.com",
                    Url = new Uri("https://github.com/gvpodev")
                }
            });

            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

            options.IncludeXmlComments(xmlPath);
        });

        return services;
    }

    public static IApplicationBuilder UseSwaggerDoc(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "BookManagerAPI");
        });

        return app;
    }
}