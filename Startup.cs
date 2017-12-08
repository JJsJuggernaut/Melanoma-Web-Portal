using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Melanoma.Startup))]
namespace Melanoma
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
