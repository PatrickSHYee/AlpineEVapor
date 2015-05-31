using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlpineEVapor.Startup))]
namespace AlpineEVapor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
