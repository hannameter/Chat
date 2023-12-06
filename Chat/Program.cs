using Chat.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("https://localhost:1000");
builder.Services.AddSignalR();

var app = builder.Build();

app.UseDefaultFiles(); // Enables default file mapping on the current path.
app.UseStaticFiles(); // Enables static file serving for the current request path.
// The preceding code allows the server to locate and serve the index.html file. 
app.MapHub<ChatHub>("/hub");


await app.RunAsync();

