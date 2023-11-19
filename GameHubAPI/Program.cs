using System.Text.Json.Serialization;
using GameHubAPI.Data;
using Microsoft.AspNetCore.Builder;

namespace GameHubAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<GameHubAPIDbContext>();
            builder.Services.AddCors();
            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseCors(opcoes => opcoes
                .WithOrigins("http://localhost:4200")
                .AllowAnyHeader().AllowAnyMethod().AllowCredentials());
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}