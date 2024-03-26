using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPP
{
    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }

        public override string ToString()
        {
            return $"Main: {main}, Description: {description}";
        }
    }

    public class Main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }

        public double ConvertToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public double ConvertToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public override string ToString()
        {
            return $"Temperature: {temp}°C, Feels like: {feels_like}°C";
        }
    }

    public class WeatherData
    {
        public Coord coord { get; set; }
        public Weather[] weather { get; set; }
        public Main main { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return $"Weather in {name}: {weather[0].main}, Temperature: {main.temp}°C, Feels like: {main.feels_like}°C";
        }
    }
}

