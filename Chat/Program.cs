var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://localhost:1000");
var app = builder.Build();
app.UseWebSockets(); // Adds the WebSocketMiddleware.
await app.RunAsync();
