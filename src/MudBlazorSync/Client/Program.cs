
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazorSync;
using Syncfusion.Blazor;
using MudBlazor.Services;
using MudBlazorSync.Application;
using MudBlazorSync.Domain;

// Version 20.4.0.40 = ODg2NDk1QDMyMzAyZTM0MmUzMGM1UDJiM0N5d0VjaXY4Z1JXTHYxTENtMEh1YnlrRmEyMmpMOFJmTWUzcTQ9
//Version 21.1.38 = MTY2MDk0NEAzMjMxMmUzMTJlMzMzOEZBVkp3Ui9aM0UwbGlLczJaS1o2aXpNYWRlTzRpYU1ZY0xoOHVQRjUzYjg9
namespace Sync
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTY2MDk0NEAzMjMxMmUzMTJlMzMzOEZBVkp3Ui9aM0UwbGlLczJaS1o2aXpNYWRlTzRpYU1ZY0xoOHVQRjUzYjg9");

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddMudServices();
            builder.Services.AddSingleton<AppState>();

            await builder.Build().RunAsync();
        }
    }
} 