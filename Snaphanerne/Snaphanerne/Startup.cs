using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Snaphanerne.Startup))]
namespace Snaphanerne
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
