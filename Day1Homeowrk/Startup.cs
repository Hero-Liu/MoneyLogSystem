using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day1Homeowrk.Startup))]
namespace Day1Homeowrk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
