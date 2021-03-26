using Blazored.LocalStorage;
using Microsoft.Extensions.DependencyInjection;

namespace Test
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBlazoredLocalStorage();
        }

    }
}
