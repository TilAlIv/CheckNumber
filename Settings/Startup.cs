using Microsoft.Extensions.Configuration;

namespace Settings;

public static class Startup
{ 
    public static IConfigurationRoot GetAppConfiguration()
    {
      IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true);
      IConfigurationRoot appConfig = builder.Build();
      return appConfig;
    }
}