using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Braun_MIS4200.Startup))]
namespace Braun_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
