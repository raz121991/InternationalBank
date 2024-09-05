using Microsoft.Extensions.Options;

namespace Configurations
{
    public class DemoService
    {
        private readonly AppSettings _appSettings;

       
        public DemoService(IOptions<AppSettings> options)
        {
            _appSettings = options.Value;
        }

        // A method that uses the injected configuration values
        public string GetSettings()
        {
            return $"Application Name: {_appSettings.ApplicationName}, Version: {_appSettings.Version}, Max Items: {_appSettings.MaxItems}";
        }

    }
}
