using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Parkingup2you.Startup))]
namespace Parkingup2you
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
