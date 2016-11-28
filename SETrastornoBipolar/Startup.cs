using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SETrastornoBipolar.Startup))]
namespace SETrastornoBipolar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
