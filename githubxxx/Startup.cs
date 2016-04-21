using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(githubxxx.Startup))]
namespace githubxxx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
