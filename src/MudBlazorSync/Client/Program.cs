using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazorSync;
using Syncfusion.Blazor;
using MudBlazor.Services;

// Version 20.4.0.38 = Nzg1ODE3QDMyMzAyZTM0MmUzMGoyN0JJQXc3VnArOHEzeVNtTlNVRXNMeVo4eDdZN3RMaUU4OGdtUG9BYTA9
namespace Sync
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Nzg1ODE3QDMyMzAyZTM0MmUzMGoyN0JJQXc3VnArOHEzeVNtTlNVRXNMeVo4eDdZN3RMaUU4OGdtUG9BYTA9");

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddMudServices();

            await builder.Build().RunAsync();
        }
    }
}