var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Run(async (HttpContext context) =>
{
    context.Response.Headers["MyKey"] = "my value"; 
    await context.Response.WriteAsync("Hello");
    await context.Response.WriteAsync(" World"); 
});

app.Run(); 