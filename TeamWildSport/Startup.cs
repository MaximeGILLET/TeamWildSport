using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamWildSport.Startup))]
namespace TeamWildSport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
