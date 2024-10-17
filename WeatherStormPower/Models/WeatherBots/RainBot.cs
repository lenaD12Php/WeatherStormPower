namespace WeatherStormPower.Models.WeatherBots;

public class RainBot : IWeatherBot
{
    private readonly double _humidityThreshold;
    private readonly string _message;
    private readonly bool _enabled;

    public RainBot(double humidityThreshold, string message, bool enabled)
    {
        _humidityThreshold = humidityThreshold;
        _message = message;
        _enabled = enabled;
    }

    public void UpdateWeather(WeatherData data)
    {
        if (_enabled && data.Humidity > _humidityThreshold)
        {
            Console.WriteLine("RainBot activated!");
            Console.WriteLine($"RainBot: {_message}");
        }
    }
}
