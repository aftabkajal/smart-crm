using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(smart_crm.Startup))]
namespace smart_crm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
