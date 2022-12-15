using BlazorApp.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using Rozklad.ClientBlazor.Infrastructure;
using Rozklad.Core;
using Rozklad.Infrastructure;
using Rozklad.Repository.Repositories;
using Syncfusion.Blazor;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSyncfusionBlazor();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Nzc3NDYzQDMyMzAyZTMzMmUzMG9WR3MzVHUvQTBHNEdmU1VZNERsWDNPU0dSdUdXQzBtMitMUHRlL09ieWM9");

await builder.Build().RunAsync();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<HttpTimetableService>();
builder.Services.AddAutoMapper(typeof(AppAutoMapper).Assembly);
builder.Services.AddRouting(options => options.LowercaseUrls = true);

