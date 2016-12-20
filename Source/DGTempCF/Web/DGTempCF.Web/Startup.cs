using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DGTempCF.Web.Startup))]
namespace DGTempCF.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
