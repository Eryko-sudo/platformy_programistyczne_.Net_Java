namespace WeatherAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<City> europeanCities = new List<City>
        {
            new City("Paris", 48.8566, 2.3522),        
            new City("London", 51.5074, -0.1278),      
            new City("Berlin", 52.5200, 13.4050),      
            new City("Rome", 41.9028, 12.4964),        
            new City("Warsaw", 52.2297, 21.0122),      
            new City("Moscow", 55.7558, 37.6176),      
            new City("Stockholm", 59.3293, 18.0686),   
            new City("Oslo", 59.9139, 10.7522),        
            new City("Copenhagen", 55.6761, 12.5683),  
            new City("Amsterdam", 52.3667, 4.8945)     
        };
            API aAPI = new API();
            aAPI.GetData(europeanCities[0].lat, europeanCities[0].lon).Wait();

      
            WeatherData weatherData = Newtonsoft.Json.JsonConvert.DeserializeObject<WeatherData>(aAPI.response);

            Console.WriteLine(weatherData.ToString());

            Console.WriteLine($"Coord: lon: {weatherData.coord.lon}, lat: {weatherData.coord.lat}");
            Console.WriteLine($"Weather: id: {weatherData.weather[0].id}, main: {weatherData.weather[0].main}, description: {weatherData.weather[0].description}, icon: {weatherData.weather[0].icon}");
            Console.WriteLine($"Main: temp: {weatherData.main.ConvertToCelsius(weatherData.main.temp)}, feels_like: {weatherData.main.ConvertToCelsius(weatherData.main.feels_like)}");
            Console.WriteLine($"Name: {weatherData.name}");

        }
    }
}
