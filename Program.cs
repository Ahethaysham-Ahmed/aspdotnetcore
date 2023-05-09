using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);
var builder = WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();


// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
