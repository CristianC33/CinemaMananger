using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(CinemaManager.Areas.Identity.IdentityHostingStartup))]
namespace CinemaManager.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}