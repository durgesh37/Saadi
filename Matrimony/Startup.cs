using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Matrimony.Startup))]
namespace Matrimony
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
