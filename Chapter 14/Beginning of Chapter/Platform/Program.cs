using Platform;
using Platform.Services;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseMiddleware<WeatherMiddleware>();

app.MapGet("endpoint/class", WeatherEndpoint.Endpoint);

IResponseFormatter formatter = new TextResponseFormatter();
app.MapGet("endpoint/function", async context => {
    await formatter.Format(context, 
        "Endpoint Function: It is sunny in LA");
});

app.Run();