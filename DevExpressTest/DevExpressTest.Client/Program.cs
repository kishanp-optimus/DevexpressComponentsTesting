using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using DevExpress.Blazor;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddDevExpressBlazor(configure => configure.BootstrapVersion = BootstrapVersion.v5);

await builder.Build().RunAsync();
