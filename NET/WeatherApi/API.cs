using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WeatherProject.FullWeather;

namespace WeatherProject
{
    internal class API
    {
        private WeatherDbContext weatherDbContext;
        private HttpClient client; 

        public API()
        {
            weatherDbContext = new WeatherDbContext();
            client = new HttpClient();
        }

        public async Task AddCityToDatabase(double lat, double lon)
        {
            string call = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid=cabfbbd83e9d1d15d1bb3e273c42662d";
            string response = await client.GetStringAsync(call);
            Root allData = JsonSerializer.Deserialize<Root>(response);
            WeatherTable weatherTable = new WeatherTable(allData.name, allData.main.temp - 273, allData.main.feels_like - 273, allData.main.pressure, allData.main.humidity, allData.wind.speed);
            weatherDbContext.Weathers.Add(weatherTable);
            weatherDbContext.SaveChanges();
        }

        public void dropDatabase()
        {
            weatherDbContext.Weathers.RemoveRange(weatherDbContext.Weathers);
            weatherDbContext.SaveChanges();
        }

        public List<WeatherTable> returnList()
        {
            return weatherDbContext.Weathers.ToList();
        }
    }
}
