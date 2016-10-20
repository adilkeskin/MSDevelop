using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DenemeWebApplication1.Startup))]
namespace DenemeWebApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
