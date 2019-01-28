using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WTGproject.Startup))]
namespace WTGproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
