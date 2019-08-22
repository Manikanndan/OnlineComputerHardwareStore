using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineComputerHardwareStore.Startup))]
namespace OnlineComputerHardwareStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
