using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sturlatest.Startup))]
namespace sturlatest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
