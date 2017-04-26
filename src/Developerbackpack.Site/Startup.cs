using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Developerbackpack.Site.Startup))]
namespace Developerbackpack.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
