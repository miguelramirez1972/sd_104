using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hangman_webforms.Startup))]
namespace Hangman_webforms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
