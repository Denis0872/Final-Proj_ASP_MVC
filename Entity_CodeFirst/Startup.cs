using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Entity_CodeFirst.Startup))]
namespace Entity_CodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
