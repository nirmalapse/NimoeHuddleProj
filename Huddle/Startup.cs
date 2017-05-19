using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Huddle.Startup))]
namespace Huddle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
