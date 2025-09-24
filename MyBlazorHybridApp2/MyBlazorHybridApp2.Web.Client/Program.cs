using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyBlazorHybridApp2.Shared.Services;
using MyBlazorHybridApp2.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the MyBlazorHybridApp2.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
