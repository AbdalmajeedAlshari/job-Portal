using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jobPortal.Startup))]
namespace jobPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
