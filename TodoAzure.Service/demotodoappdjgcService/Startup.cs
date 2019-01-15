using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(demotodoappdjgcService.Startup))]

namespace demotodoappdjgcService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}