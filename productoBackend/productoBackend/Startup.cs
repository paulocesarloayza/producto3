using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(productoBackend.Startup))]
namespace productoBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
