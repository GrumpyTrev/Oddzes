using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Oddzes.Startup))]
namespace Oddzes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
