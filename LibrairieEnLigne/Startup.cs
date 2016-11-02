using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibrairieEnLigne.Startup))]
namespace LibrairieEnLigne
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
