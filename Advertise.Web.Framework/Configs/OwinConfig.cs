using Owin;

namespace Advertise.Web.Framework.Configs
{
    public class OwinConfig
    {
        #region Public Methods

        public static void Configuration(IAppBuilder appBuilder)
        {
            AspNetIdentityConfig.RegisterAspNetIdentity(appBuilder);
        }

        #endregion Public Methods
    }
}