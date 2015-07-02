using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Midterm2.Startup))]
namespace Midterm2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
