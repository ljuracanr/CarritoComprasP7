using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarritoComprasP7.Startup))]
namespace CarritoComprasP7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
