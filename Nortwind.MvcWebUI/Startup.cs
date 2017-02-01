using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nortwind.MvcWebUI.Startup))]
namespace Nortwind.MvcWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
