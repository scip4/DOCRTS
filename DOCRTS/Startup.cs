using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DOCRTS.Startup))]
namespace DOCRTS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
