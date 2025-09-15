var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseRouting();

//app.Map("/Home", () => "Hello World!"); ---> Works on all HTTP Methods

//app.MapGet("/Home", () => "Hello World! --- Get");
//app.MapPut("/Home", () => "Hello World! --- Put");
//app.MapPost("/Home", () => "Hello World! ---Post");
//app.MapDelete("/Home", () => "Hello World! ---Delete");

app.UseEndpoints(endpoints => {

    endpoints.MapGet("/Home", async (context) =>
    {
        await context.Response.WriteAsync("Hello to Get Request");
    });

    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("Hello to Post Request");
    });

    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("Hello to Delete Request");
    });
});

app.Run( async(HttpContext context) =>
{
    await context.Response.WriteAsync("Hello to the C#");
});


//app.MapGet("/About", () => "About Us Page");

//app.MapDefaultControllerRoute();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=About}/{id?}"
//    );

//app.MapControllers();

app.Run();
