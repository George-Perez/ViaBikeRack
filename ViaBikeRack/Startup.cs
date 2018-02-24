using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViaBikeRack.Startup))]
namespace ViaBikeRack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
