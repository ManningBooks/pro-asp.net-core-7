using Microsoft.EntityFrameworkCore;
using Platform.Models;
using Platform.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOutputCache(opts => {
    opts.AddBasePolicy(policy => {
        policy.Cache();
        policy.Expire(TimeSpan.FromSeconds(10));
    });
    opts.AddPolicy("30sec", policy => {
        policy.Cache();
        policy.Expire(TimeSpan.FromSeconds(30));
    });
});

builder.Services.AddSingleton<IResponseFormatter,
    HtmlResponseFormatter>();

builder.Services.AddDbContext<CalculationContext>(opts => {
    opts.UseSqlServer(
        builder.Configuration["ConnectionStrings:CalcConnection"]);
    opts.EnableSensitiveDataLogging(true);
});

builder.Services.AddTransient<SeedData>();

var app = builder.Build();

app.UseOutputCache();

app.MapEndpoint<Platform
    .SumEndpoint>("/sum/{count:int=1000000000}")
    .CacheOutput();

app.MapEndpoint<Platform
    .SumEndpoint>("/sum30/{count:int=1000000000}")
    .CacheOutput("30sec");

app.MapGet("/", async context => {
    await context.Response.WriteAsync("Hello World!");
});

bool cmdLineInit = (app.Configuration["INITDB"] ?? "false") == "true";
if (app.Environment.IsDevelopment() || cmdLineInit) {
    var seedData = app.Services.GetRequiredService<SeedData>();
    seedData.SeedDatabase();
}
if (!cmdLineInit) {
    app.Run();
}
