namespace WeatherStormPower.Models;

public interface IWeatherDataConverter
{
    WeatherData Convert(string input);
}
