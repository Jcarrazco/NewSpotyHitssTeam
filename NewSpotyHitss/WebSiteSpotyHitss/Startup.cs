using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSiteSpotyHitss.Startup))]
namespace WebSiteSpotyHitss
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
