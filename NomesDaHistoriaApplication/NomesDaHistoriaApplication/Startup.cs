using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NomesDaHistoriaApplication.Startup))]
namespace NomesDaHistoriaApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
