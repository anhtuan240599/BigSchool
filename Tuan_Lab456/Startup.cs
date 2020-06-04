using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tuan_Lab456.Startup))]
namespace Tuan_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
