using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stockie.Startup))]
namespace Stockie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
