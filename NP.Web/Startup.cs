using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NP.Web.Startup))]
namespace NP.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
