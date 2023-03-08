using Microsoft.Extensions.Configuration;

namespace Config.Config
{
    public class Config
    {
        public static IConfiguration Configuration;

        public static string GetConfig(string key)
        {
            return Configuration.GetValue<string>(key);
        }
    }
}
