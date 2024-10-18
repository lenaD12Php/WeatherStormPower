namespace WeatherStormPower.Models.WeatherBots;

public class SunBot : IWeatherBot
{
    private readonly double _temperatureThreshold;
    private readonly string _message;
    private readonly bool _enabled;

    public SunBot(double temperatureThreshold, string message, bool enabled)
    {
        _temperatureThreshold = temperatureThreshold;
        _message = message;
        _enabled = enabled;
    }

    public void UpdateWeather(WeatherData data)
    {
        if (_enabled && data.Temperature > _temperatureThreshold)
        {
            Console.WriteLine("SunBot activated!");
            Console.WriteLine($"SunBot: {_message}");
        }
    }
}
