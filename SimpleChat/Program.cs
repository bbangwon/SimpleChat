var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddSignalR();
var app = builder.Build();

app.UseStaticFiles();
app.MapRazorPages();
app.MapHub<SimpleChat.Hubs.SimpleChat>("/simplechat");
//app.MapGet("/", () => "Hello World!");

app.Run();
