using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SM.Startup))]
namespace SM
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
