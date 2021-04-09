using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
// Blazorise
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
// Blazorise

namespace MWFManagementConsoleWebApp
{
    public class Program
    {
        private static async Task DebugDelayAsync()
        {
#if DEBUG
            await Task.Delay(5000);
#endif
        }



        public static async Task Main(string[] args)
        {
            // This is a temporary solution to debugger sometimes not working until Microsoft fixes this Blazor bug
            await DebugDelayAsync();




            var builder = WebAssemblyHostBuilder.CreateDefault(args);

                builder.Services
          .AddBlazorise(options =>
          {
              options.ChangeTextOnKeyPress = true;
          })
          .AddBootstrapProviders()
          .AddFontAwesomeIcons();

            builder.RootComponents.Add<App>("app");


            builder.Services.AddHttpClient<HostServicesHttpClient>();

            builder.Services.AddHttpClient<DatabaseServicesHttpClient>();


            /*await builder.Build().RunAsync();*/   // This was commented out because we need to first add servuces before we RunAsync()
            var host = builder.Build();

            await host.RunAsync();
        }
    }
}
