using Blazored.LocalStorage;
using despesas_blazor_webAssembly;
using despesas_blazor_webAssembly.Service;
using despesas_blazor_webAssembly.Service.Interface;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<ISpendService, SpendService>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();

await builder.Build().RunAsync();
