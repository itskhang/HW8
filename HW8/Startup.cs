using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HW8.Startup))]
namespace HW8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
