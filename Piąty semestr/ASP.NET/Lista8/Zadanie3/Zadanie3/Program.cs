var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetService<IConfiguration>();

var name = configuration.GetValue<string>("Foo");

app.UseFirstMiddleware();
app.Run(async (context) =>
{
    await context.Response.WriteAsync("drugie middleware: start\n");
    await context.Response.WriteAsync("drugie middleware: end\n");
});
app.Run();
public class FirstMiddleware
{
    private readonly RequestDelegate _next;
    

    public FirstMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("pierwsze middleware: start\n");
     //   var foo = this._configuration["AppSettings:Foo"];
       // var qux = this._configuration["AppSettings:Qux"];
        await _next(context);
        await context.Response.WriteAsync("pierwsze middleware: end\n");
    }
}
public static class FirstMiddlewareExtensions
{
    public static IApplicationBuilder UseFirstMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<FirstMiddleware>();
    }
}