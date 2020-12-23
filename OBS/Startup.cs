using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OBS.Startup))]
namespace OBS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
