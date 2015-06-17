using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KCCodeMentors_Darlene.Startup))]
namespace KCCodeMentors_Darlene
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
