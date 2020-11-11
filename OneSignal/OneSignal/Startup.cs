using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OneSignal.Startup))]
namespace OneSignal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
