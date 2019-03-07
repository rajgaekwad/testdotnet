using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testdotnet.Startup))]
namespace testdotnet
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
