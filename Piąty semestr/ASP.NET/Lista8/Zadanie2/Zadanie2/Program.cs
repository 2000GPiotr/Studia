var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
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
        var cookie = context.Request.Cookies["cookie"];
        if (string.IsNullOrEmpty(cookie))
        {
            context.Response.Cookies.Append("cookie", "foo");
        }
        
        await context.Response.WriteAsync("pierwsze middleware: start\n");
        await context.Response.WriteAsync(cookie + "\n");
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