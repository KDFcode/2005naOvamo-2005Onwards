using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2005naOvamo.Startup))]
namespace _2005naOvamo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
