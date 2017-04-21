using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FakeProject.Startup))]
namespace FakeProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
