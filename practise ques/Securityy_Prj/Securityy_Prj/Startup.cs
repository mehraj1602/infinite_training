using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Securityy_Prj.Startup))]
namespace Securityy_Prj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
