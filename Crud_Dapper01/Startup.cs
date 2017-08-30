using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Crud_Dapper01.Startup))]
namespace Crud_Dapper01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
