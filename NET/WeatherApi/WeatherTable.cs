using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherProject
{
    internal class WeatherTable
    {
        public int Id { get; set; }
        public string city_name { get; set; }
        public double temp { get; set; }
        public double feels_like { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public double speed { get; set; }

        public WeatherTable(string city_name, double temp, double feels_like, int pressure, int humidity, double speed) 
        {
            this.city_name = city_name;
            this.temp = temp;
            this.feels_like = feels_like;
            this.pressure = pressure;
            this.humidity = humidity;
            this.speed = speed;
        }
    }
}
