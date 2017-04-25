using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BK_WebApp.Startup))]
namespace BK_WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
