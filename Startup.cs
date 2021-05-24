using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CovidCare.Startup))]
namespace CovidCare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
