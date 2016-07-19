using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Diamond.Web.Operation.Startup))]
namespace Diamond.Web.Operation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
