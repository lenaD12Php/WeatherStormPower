using Newtonsoft.Json;

namespace WeatherStormPower;

public class BotConfigurationHandler
{
    public static Dictionary<string, BotConfiguration> LoadConfiguration(string filePath)
    {
        string configurationJson = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<Dictionary<string, BotConfiguration>>(configurationJson);
    }
}
