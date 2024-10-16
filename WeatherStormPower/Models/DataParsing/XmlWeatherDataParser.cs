using System.IO;
using System.Xml.Serialization;

namespace WeatherStormPower.Models.DataConversion;

public class XmlWeatherDataParser : IWeatherDataParser
{
    public WeatherData Parse(string input)
    {
        var serializer = new XmlSerializer(typeof(WeatherData));
        using (var reader = new StringReader(input))
        {
            return (WeatherData)serializer.Deserialize(reader);
        }
    }
}


