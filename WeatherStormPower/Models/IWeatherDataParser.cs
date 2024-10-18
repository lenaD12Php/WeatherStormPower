namespace WeatherStormPower.Models;

public interface IWeatherDataParser
{
    WeatherData Parse(string input);
}
