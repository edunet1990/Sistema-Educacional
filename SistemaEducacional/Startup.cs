using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaEducacional.Startup))]
namespace SistemaEducacional
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
