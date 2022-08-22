using HelloWorld;
using Microsoft.Extensions.Configuration;

namespace HelloWorld
{
    public class Localization
    {
        public RequestLocalizationOptions GetLocalizationOptions(ConfigurationManager configuration)
        {
            var cultures = configuration.GetSection("Cultures").GetChildren().ToDictionary(x => x.Key, x => x.Value);

            var supportedCultures = cultures.Keys.ToArray();

            var localizationOptions = new RequestLocalizationOptions()
                .AddSupportedCultures(supportedCultures) // 12/31/2020 -> 31.12.2020
                .AddSupportedUICultures(supportedCultures); // HelloWorld -> HalloWelt

            return localizationOptions;
        }
    }
}
