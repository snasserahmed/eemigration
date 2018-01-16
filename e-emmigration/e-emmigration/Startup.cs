using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(e_emmigration.Startup))]
namespace e_emmigration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
