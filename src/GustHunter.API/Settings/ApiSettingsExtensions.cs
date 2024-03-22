namespace GustHunter.API.Settings
{
	public static class ApiSettingsExtensions
	{
		public static WebApplicationBuilder AddAPIServices(this WebApplicationBuilder builder)
		{
			builder.Services.AddAuthorization();			

			return builder;
		}

		public static WebApplicationBuilder AddSwaggerServices(this WebApplicationBuilder builder)
		{			
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			return builder;
		}

		public static WebApplication ConfigureSwagger(this WebApplication app) {
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}
			return app;
		}

		public static WebApplication ConfigureAppSettings(this WebApplication app)
		{
			app.UseHttpsRedirection();
			return app;
		}

		public static WebApplication ConfigureAppSec(this WebApplication app)
		{
			app.UseAuthorization();
			return app;		
		}
	
	}
}
