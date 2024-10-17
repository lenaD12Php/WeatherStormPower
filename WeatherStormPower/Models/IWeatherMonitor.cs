namespace WeatherStormPower.Models;

public interface IWeatherMonitor
{
    void RegisterBot(IWeatherBot bot);
    void UnregisterBot(IWeatherBot bot);
    void NotifyBots(WeatherData data);
}
