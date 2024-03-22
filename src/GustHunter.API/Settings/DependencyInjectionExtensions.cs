using GustHunter.API.Services;

namespace GustHunter.API.Settings
{
	public static class DependencyInjectionExtensions
	{
		public static WebApplicationBuilder AddWeatherService(this WebApplicationBuilder builder)
		{
			string? apiKey = builder.Configuration["OpenWeatherAPI:ServiceApiKey"];
			builder.Services.AddScoped<WeatherService>((WeatherService) => new WeatherService(apiKey));

			return builder;
		}
	}
}
