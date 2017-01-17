using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pl.lodz.p.ftims.edu.pai.web.Startup))]
namespace pl.lodz.p.ftims.edu.pai.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
