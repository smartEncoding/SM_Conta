using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SM_Conta.Startup))]
namespace SM_Conta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
