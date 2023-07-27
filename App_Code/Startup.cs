using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Matixs.Startup))]
namespace Matixs
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
