using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Travel_Blog.Startup))]
namespace Travel_Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
