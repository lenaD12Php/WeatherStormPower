namespace WeatherStormPower.Models.WeatherBots;

public class SnowBot : IWeatherBot
{
    private readonly double _temperatureThreshold;
    private readonly string _message;
    private readonly bool _enabled;

    public SnowBot(double temperatureThreshold, string message, bool enabled)
    {
        _temperatureThreshold = temperatureThreshold;
        _message = message;
        _enabled = enabled;
    }

    public void UpdateWeather(WeatherData data)
    {
        if (_enabled && data.Temperature < _temperatureThreshold)
        {
            Console.WriteLine("SnowBot activated!");
            Console.WriteLine($"SnowBot: {_message}");
        }
    }
}
