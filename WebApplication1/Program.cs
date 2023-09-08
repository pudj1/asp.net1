using WebApplication1;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
Random rand = new();
Company company = new("Samsung", 1000);
app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    var stringBuilder = new System.Text.StringBuilder("");
    stringBuilder.Append($"{company.name} - {company.value}<br>");
    stringBuilder.Append($"<text>{rand.Next(0, 101)}</text>");
    await context.Response.WriteAsync(stringBuilder.ToString());
});


app.Run();