using System.Text.Json;

namespace WeatherStormPower.Models.DataParsing;

public class JsonWeatherDataParsing : IWeatherDataParser
{
    public WeatherData Parse(string jsonData)
    {
        return JsonSerializer.Deserialize<WeatherData>(jsonData);
    }
}
