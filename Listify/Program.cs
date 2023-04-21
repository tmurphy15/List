using System;

namespace Listify
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();


            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();

            app.MapGet("/", () => Results.Ok("Hello, world"));

            app.MapGet("/listify", (int begin, int end, int index) =>
            {
                try
                {
                    var listify = new Listify(begin, end);

                    return Results.Ok(listify[index]);

                }
                catch (ArgumentOutOfRangeException ex)
                {
                    return Results.BadRequest($"{ex.Message}");
                }
                catch (Exception ex)
                {
                    return Results.Problem($"{ex.Message}");
                }

            });

            app.Run();
        }
    }
}