using WeatherStormPower.Models.WeatherBots;
using WeatherStormPower.Models.DataParsing;
using WeatherStormPower.Models;

namespace WeatherStormPower;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Json File Path for the Bot Configuration: ");
        var FilePath = Console.ReadLine();
        var configurations = BotConfigurationHandler.LoadConfiguration(FilePath);
        
        Console.WriteLine();

        Console.WriteLine("Enter weather data (in JSON format or XML format.");
        string input = Console.ReadLine()+ Console.ReadLine()+Console.ReadLine()+ Console.ReadLine() + Console.ReadLine();

        Console.WriteLine() ;

        IWeatherDataParser parser;
        if (input.TrimStart().StartsWith("{"))
            parser = new JsonWeatherDataParsing();
        else
            parser = new XmlWeatherDataParsing();

        var weatherMonitor = new WeatherMonitor();
        if (configurations["RainBot"].Enabled)
            weatherMonitor.RegisterBot(new RainBot(configurations["RainBot"].Threshold, configurations["RainBot"].Message, configurations["RainBot"].Enabled));
        if (configurations["SunBot"].Enabled)
            weatherMonitor.RegisterBot(new SunBot(configurations["SunBot"].Threshold, configurations["SunBot"].Message, configurations["SunBot"].Enabled));
        if (configurations["SnowBot"].Enabled)
            weatherMonitor.RegisterBot(new SnowBot(configurations["SnowBot"].Threshold, configurations["SnowBot"].Message, configurations["SnowBot"].Enabled));

        var weatherData = parser.Parse(input);
        weatherMonitor.NotifyBots(weatherData);
    }
}

