using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimkenTest.Startup))]
namespace TimkenTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
