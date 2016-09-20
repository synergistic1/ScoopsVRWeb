using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScoopsVR.Startup))]
namespace ScoopsVR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
