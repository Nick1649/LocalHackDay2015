using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LocalHackDay.Startup))]
namespace LocalHackDay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
