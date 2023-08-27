using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazor_SyncFusionExamples;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


// Add Syncfusion 
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjY2NTYxNkAzMjMyMmUzMDJlMzBFQUJmeGJ4akxUSEtEZ21sMmtFL3NGUWE2L1diT1oxSGNCODI2NXBtcE5vPQ==");  
builder.Services.AddSyncfusionBlazor();

await builder.Build().RunAsync();
