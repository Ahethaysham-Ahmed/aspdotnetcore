using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.UseStartup<Startup>();

        if (!webBuilder.GetSetting("Environment").Equals("Development"))
        {
            webBuilder.UseExceptionHandler("/Error");
        }
        webBuilder.UseStaticFiles();

        webBuilder.UseRouting();

        webBuilder.UseAuthorization();

        webBuilder.UseEndpoints(endpoints =>
        {
            endpoints.MapRazorPages();
        });
    });

var app = builder.Build();

app.Run();
