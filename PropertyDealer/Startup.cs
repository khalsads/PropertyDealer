using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PropertyDealer.Startup))]
namespace PropertyDealer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
