var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

var app = builder.Build();

app.MapGet("/", () => "Hello Ismet!");

app.Run();
