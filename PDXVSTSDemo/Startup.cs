using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PDXVSTSDemo.Startup))]
namespace PDXVSTSDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
