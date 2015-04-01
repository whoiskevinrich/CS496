using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using Universities;

[assembly: OwinStartup(typeof(Startup))]
namespace Universities
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
