using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExpensesManage.Startup))]
namespace ExpensesManage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
