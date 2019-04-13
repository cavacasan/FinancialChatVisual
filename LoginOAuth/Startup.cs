using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginOAuth.Startup))]
namespace LoginOAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
