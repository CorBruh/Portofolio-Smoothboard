using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Smoothboard.Startup))]
namespace Smoothboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
