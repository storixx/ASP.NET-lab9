using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication9.Models;

namespace WebApplication9.Components.Weather;

public class WeatherViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(string city)
    {
        var url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid=1a7623222dbe23345549f83cc4fe1c3f";
        WeatherInfo weatherInfo = null;

        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.GetStringAsync(url);
            weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(response);
        }

        return View(weatherInfo);
    }
}
