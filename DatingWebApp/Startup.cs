using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatingWebApp.Startup))]
namespace DatingWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
