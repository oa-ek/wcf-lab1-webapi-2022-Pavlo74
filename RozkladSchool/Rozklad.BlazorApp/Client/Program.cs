using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Rozklad.BlazorApp.Client;
using Blazored.LocalStorage;
using RozkladClient.Infrastructure;
using Syncfusion.Blazor;
using Blazored.Modal;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri($"{builder.HostEnvironment.BaseAddress} api/") });


//builder.Services.AddScoped<HttpCurrencyPairService>();
builder.Services.AddScoped<HttpTimetableService>();
//builder.Services.AddScoped<HttpStatusService>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredModal();
builder.Services.AddSyncfusionBlazor();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Nzc5OTg2QDMyMzAyZTMzMmUzMGI2Umd1OGlFYzNaY254UDJmTDlzS05zeDdoSW15K2U0eXNwcXFIWmM4c1U9");


await builder.Build().RunAsync();
