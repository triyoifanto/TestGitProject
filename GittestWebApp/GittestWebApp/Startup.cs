using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GittestWebApp.Startup))]
namespace GittestWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
