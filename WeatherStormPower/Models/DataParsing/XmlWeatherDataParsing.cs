using System.Xml.Linq;

namespace WeatherStormPower.Models.DataParsing;

public class XmlWeatherDataParsing : IWeatherDataParser
{
    public WeatherData Parse(string xmlData)
    {
        var xDoc = XDocument.Parse(xmlData);
        return new WeatherData
        {
            Location = xDoc.Root.Element("Location").Value,
            Temperature = double.Parse(xDoc.Root.Element("Temperature").Value),
            Humidity = double.Parse(xDoc.Root.Element("Humidity").Value)
        };
    }
}


