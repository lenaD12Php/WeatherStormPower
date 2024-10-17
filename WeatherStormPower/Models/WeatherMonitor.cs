namespace WeatherStormPower.Models;

public class WeatherMonitor :IWeatherMonitor
{
    private List<IWeatherBot> _bots = new List<IWeatherBot>();

    public void RegisterBot(IWeatherBot bot)
    {
        _bots.Add(bot);
    }

    public void UnregisterBot(IWeatherBot bot)
    {
        _bots.Remove(bot);
    }

    public void NotifyBots(WeatherData data)
    {
        foreach (var bot in _bots)
            bot.UpdateWeather(data);
    }
}
