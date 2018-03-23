using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_13.EmployeesMVC.Startup))]
namespace _13.EmployeesMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
