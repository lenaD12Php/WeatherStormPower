using System.Text.Json;

namespace WeatherStormPower.Models.DataConversion;

public class JsonWeatherDataConverter : IWeatherDataConverter
{
    public WeatherData Convert(string input) 
        => JsonSerializer.Deserialize<WeatherData>(input);
}
