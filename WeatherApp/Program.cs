
using Microsoft.EntityFrameworkCore;
using WeatherApp.Data;
using WeatherApp.Data.Models;
using WeatherApp.Data.Repositories;
using WeatherApp.Data.Repositories.Interfaces;
using WeatherApp.Services;
using WeatherApp.Services.Configuration;
using WeatherApp.Services.Interfaces;

namespace WeatherApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<WeatherAppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.Configure<WeatherApiSettings>(builder.Configuration.GetSection("WeatherApi"));

            // Register the HttpClient for your service
            builder.Services.AddHttpClient<ILocationService, LocationService>(client =>
            {
                client.BaseAddress = new Uri(builder.Configuration["WeatherApi:BaseUrl"]!);
            });

            builder.Services.AddScoped<ISavedLocationRepository, SavedLocationRepository>();

            builder.Services.AddIdentityApiEndpoints<ApplicationUser>()
                .AddEntityFrameworkStores<WeatherAppDbContext>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
