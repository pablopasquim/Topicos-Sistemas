var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// http://localhost:5277/
app.MapGet("/", () => "Hello World!");
app.MapGet("/treino", () => "Treino");
app.Run();

