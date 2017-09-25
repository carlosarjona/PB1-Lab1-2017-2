using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prova.Startup))]
namespace prova
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
