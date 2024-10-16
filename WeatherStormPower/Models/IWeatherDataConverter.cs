namespace WeatherStormPower.Models;

public interface IWeatherDataConverter
{
    WeatherData Convert(WeatherData data);
}
