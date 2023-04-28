
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
            string licensekey = "Mgo+DSMBaFt+QHFqVk5rXVNbdV5dVGpAd0N3RGlcdlR1fUUmHVdTRHRcQllhQX5Vc01hX3ZfeHw=;Mgo+DSMBPh8sVXJ1S0d+X1lPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSXpRfkVlXHdcdn1WRGg=;ORg4AjUWIQA/Gnt2VFhhQlJMfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn5XdE1jX3pWcnJcQmdU;MTg2ODQ5NUAzMjMxMmUzMTJlMzMzOEo1OXN4bGk3SnhDdkM2QmJidG5oMi8wcjJxU3FKdlVlK3JpQTBGazRtNUU9;MTg2ODQ5NkAzMjMxMmUzMTJlMzMzOG50R3Zjc2xGSlhjaGhwemhkanBQc3FHRlhqUStHcU9wOG5iTGM3RGF5Mkk9;NRAiBiAaIQQuGjN/V0d+XU9HflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TckdrWXlbeHZSRmFUWQ==;MTg2ODQ5OEAzMjMxMmUzMTJlMzMzOGVqVGdXQUJ3Q0wrYUZLY0FLS3YrTVpZU3JkWE5Jd2FlVHU4VGQwbmJoZWM9;MTg2ODQ5OUAzMjMxMmUzMTJlMzMzOGZEeVJCTkZWV01hM21TOSt0N0Zsa1BHZCtnVGpMR3JFeVI1U29Qa3lLWEU9;Mgo+DSMBMAY9C3t2VFhhQlJMfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn5XdE1jX3pWcnNVT2ZU;MTg2ODUwMUAzMjMxMmUzMTJlMzMzOEJSangyMXdraWRYSzhHVDQwOG1rZnk0WEhYSkdWZStSQ0E1T09TM1FIZ3c9;MTg2ODUwMkAzMjMxMmUzMTJlMzMzOERiVTFjelgydTdxQk5IMGFnT1pNZWJZM20vc1hwRGUwUU44eE1RdEoraUE9;MTg2ODUwM0AzMjMxMmUzMTJlMzMzOGVqVGdXQUJ3Q0wrYUZLY0FLS3YrTVpZU3JkWE5Jd2FlVHU4VGQwbmJoZWM9";
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(licensekey);

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