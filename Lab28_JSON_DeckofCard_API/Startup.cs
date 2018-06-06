using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab28_JSON_DeckofCard_API.Startup))]
namespace Lab28_JSON_DeckofCard_API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
