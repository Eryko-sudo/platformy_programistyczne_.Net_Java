using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace WeatherAPP
{
    public class API
    {
        public HttpClient client;
        public string response;
        public async Task GetData(double lat, double lon)
        {
            client = new HttpClient();
            string call = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid=3572e1f9f64d3de9f4ecfda10b11a35a";
            response = await client.GetStringAsync(call);
            //Console.WriteLine(response);
        }
    }
}
