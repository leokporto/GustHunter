using System.Text.Json.Serialization;

namespace GustHunter.API.Entity
{
	public class OpenWeatherForecast
	{
		//[JsonPropertyName("cod")]
		//public string Cod { get; set; } = "";

		//[JsonPropertyName("message")]
		//public int? Message { get; set; }

		[JsonPropertyName("cnt")]
		public int? TimestampsCount { get; set; }

		[JsonPropertyName("list")]
		public List<Forecast> Forecasts { get; set; } = new();

		[JsonPropertyName("city")]
		public City City { get; set; } = new();
	}

	public class City
	{
		[JsonPropertyName("id")]
		public int? Id { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; } = "";

		[JsonPropertyName("coord")]
		public Coordinates Coordinates { get; set; } = new();

		[JsonPropertyName("country")]
		public string? Country { get; set; }

		//[JsonPropertyName("population")]
		//public int? Population { get; set; }

		[JsonPropertyName("timezone")]
		public int? TimezoneUTC { get; set; }

		[JsonPropertyName("sunrise")]
		public int? SunriseTimeUTC { get; set; }

		[JsonPropertyName("sunset")]
		public int? SunsetTimeUTC { get; set; }
	}

	public class Clouds
	{
		/// <summary>
		/// Gets or sets the cloudiness.
		/// </summary>
		/// <value>
		/// The percentage of cloudiness.
		/// </value>
		[JsonPropertyName("all")]
		public int? Cloudiness { get; set; }
	}

	public class Coordinates
	{
		[JsonPropertyName("lat")]
		public double? Latitude { get; set; }

		[JsonPropertyName("lon")]
		public double? Longitude { get; set; }
	}

	public class Forecast
	{
		[JsonPropertyName("dt")]
		public int? UTCTimestampTicks { get; set; }

		[JsonPropertyName("main")]
		public Main Main { get; set; } = new();

		[JsonPropertyName("weather")]
		public List<Weather> Weather { get; set; } = new();

		[JsonPropertyName("clouds")]
		public Clouds Clouds { get; set; } = new();

		[JsonPropertyName("wind")]
		public Wind Wind { get; set; } = new();

		/// <summary>
		/// Gets or sets the Average visibility in metres. The maximum value of the visibility is 10km. 
		/// </summary>
		/// <value>
		/// The visibility.
		/// </value>
		[JsonPropertyName("visibility")]
		public int? Visibility { get; set; }

		/// <summary>
		/// Gets or sets the Probability of precipitation. The values of the parameter vary between 0 and 1, where 0 is equal to 0%, 1 is equal to 100%
		/// </summary>
		/// <value>
		/// the Probability of precipitation.
		/// </value>
		[JsonPropertyName("pop")]
		public double? Precipitation { get; set; }

		[JsonPropertyName("rain")]
		public Rain? Rain { get; set; }

		//[JsonPropertyName("sys")]
		//public Sys Sys { get; set; }

		[JsonPropertyName("dt_txt")]
		public string? UTCTimestamp { get; set; }
	}

	public class Main
	{
		[JsonPropertyName("temp")]
		public double? Temperature { get; set; }

		[JsonPropertyName("feels_like")]
		public double? FeelsLike { get; set; }

		[JsonPropertyName("temp_min")]
		public double? TempMin { get; set; }

		[JsonPropertyName("temp_max")]
		public double? TempMax { get; set; }

		/// <summary>
		/// Gets or sets the pressure.
		/// </summary>
		/// <value>
		/// The pressure in hPa.
		/// </value>
		[JsonPropertyName("pressure")]
		public int? Pressure { get; set; }

		/// <summary>
		/// Gets or sets the sea level preassure.
		/// </summary>
		/// <value>
		/// The sea level preassure in hPa.
		/// </value>
		[JsonPropertyName("sea_level")]
		public int? SeaLevelPreassure { get; set; }

		/// <summary>
		/// Gets or sets the ground level preassure.
		/// </summary>
		/// <value>
		/// The ground level preassure in hPa.
		/// </value>
		[JsonPropertyName("grnd_level")]
		public int? GroundLevelPreassure { get; set; }

		[JsonPropertyName("humidity")]
		public int? Humidity { get; set; }

		//[JsonPropertyName("temp_kf")]
		//public double? TempKf { get; set; }
	}

	public class Rain
	{
		/// <summary>
		/// Gets or sets the Rain volume for last 3 hours, mm. Please note that only mm as units of measurement are available for this parameter
		/// </summary>
		/// <value>
		/// The the Rain volume for last 3 hours.
		/// </value>
		[JsonPropertyName("3h")]
		public double? VolumeLast3Hours { get; set; }
	}

	

	//public class Sys
	//{
	//	/// <summary>
	//	/// Gets or sets the part of day.
	//	/// </summary
	//	/// <value>
	//	/// Returns "d" for day or "n" for night
	//	/// </value>
	//	[JsonPropertyName("pod")]
	//	public string PartOfDay { get; set; } = "";
	//}

	public class Weather
	{
		[JsonPropertyName("id")]
		public int? Id { get; set; }

		/// <summary>
		/// Gets or sets the weather Group.
		/// </summary>
		/// <value>
		/// The weather Group (Rain, Snow, Clouds etc.)
		/// </value>
		[JsonPropertyName("main")]
		public string Group { get; set; } = "";

		[JsonPropertyName("description")]
		public string Description { get; set; } = "";

		/// <summary>
		/// Gets or sets the icon.
		/// </summary>
		/// <remarks>To get the Icon from openweather use the following link: https://openweathermap.org/img/wn/10d@2x.png.
		/// Substitute the name of the image on the link for the value of this property</remarks>
		/// <value>
		/// The icon.
		/// </value>
		[JsonPropertyName("icon")]
		public string? Icon { get; set; }
	}

	public class Wind
	{
		/// <summary>
		/// Gets or sets the speed.
		/// </summary>
		/// <remarks>Unit Default: meter/sec, Metric: meter/sec, Imperial: miles/hour.</remarks>
		/// <value>
		/// The speed.
		/// </value>
		[JsonPropertyName("speed")]
		public double? Speed { get; set; }

		/// <summary>
		/// Gets or sets the wind direction in degrees (meteorological)
		/// </summary>
		/// <value>
		/// the wind direction in degrees.
		/// </value>
		[JsonPropertyName("deg")]
		public int? Direction { get; set; }

		/// <summary>
		/// Gets or sets the gust.
		/// </summary>
		/// "<remarks>Unit Default: meter/sec, Metric: meter/sec, Imperial: miles/hour.</remarks>
		/// <value>
		/// The Wind gust. 
		/// </value>
		[JsonPropertyName("gust")]
		public double? Gust { get; set; }
	}


}
