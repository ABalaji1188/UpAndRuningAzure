using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UpAndRuningAzure.Startup))]
namespace UpAndRuningAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
