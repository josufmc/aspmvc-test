using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_7.MySecurityMVC.Startup))]
namespace _7.MySecurityMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
