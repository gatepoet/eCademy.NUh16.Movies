using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eCademy.NUh16.Movies.Web.Startup))]
namespace eCademy.NUh16.Movies.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
