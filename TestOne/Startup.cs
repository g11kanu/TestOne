using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestOne.Startup))]
namespace TestOne
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
