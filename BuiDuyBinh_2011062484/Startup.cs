using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuiDuyBinh_2011062484.Startup))]
namespace BuiDuyBinh_2011062484
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
