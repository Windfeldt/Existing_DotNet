using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(drinkmorecoffeeService.Startup))]

namespace drinkmorecoffeeService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}