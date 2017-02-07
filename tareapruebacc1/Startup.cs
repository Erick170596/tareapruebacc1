using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tareapruebacc1.Startup))]
namespace tareapruebacc1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
