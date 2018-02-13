using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppK.Startup))]
namespace WebAppK
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
