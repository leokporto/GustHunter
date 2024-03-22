using GustHunter.API.Entity;
using Microsoft.AspNetCore.Http.HttpResults;

namespace GustHunter.API.Services
{
	public class WeatherService : HttpClient
	{
		private readonly string? _apiKey = "";

		public WeatherService()
		{
			this.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/");
			//client.DefaultRequestHeaders.Add("Accept", "application/json");
		}

		public WeatherService(string? key) : this()
		{
			_apiKey = key;
		}
		

		public async Task<object?> GetWeatherForecastAsync(string city, string language = "pt_br")
		{
			if (string.IsNullOrWhiteSpace(_apiKey) || string.IsNullOrWhiteSpace(city))
				return null;

			// "forecast?lat={lat}&lon={lon}&appid={_apiKey}"
			var response = await this.GetFromJsonAsync<OpenWeatherForecast>($"forecast?q={city}&units=metric&lang={language}&appid={_apiKey}");
			 
			return response;
		}

	}
}
