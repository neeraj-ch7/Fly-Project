var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    return Results.Json(new
    {
        message = "Hello World"
    });
});

app.MapGet("/about", () =>
{
    return Results.Json(new
    {
        name = "Neeraj",
        role = "Backend Intern"
    });
});

app.Run();
