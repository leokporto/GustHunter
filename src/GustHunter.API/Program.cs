
using GustHunter.API.Services;
using GustHunter.API.Settings;

namespace GustHunter.API
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.AddAPIServices()
				.AddSwaggerServices()
				.AddWeatherService();

			var app = builder.Build();

			app.ConfigureSwagger()
				.ConfigureAppSettings()
				.ConfigureAppSec();



			

			app.MapGet("/weatherforecast", async (WeatherService weatherSvc) =>
			{
				var result = await weatherSvc.GetWeatherForecastAsync("Brasilia,DF,BR");
				if(result == null)
					return Results.NotFound();
				
				return Results.Ok(result);
			})
			.WithName("GetWeatherForecast")
			.WithOpenApi();

			app.Run();
		}
	}
}
