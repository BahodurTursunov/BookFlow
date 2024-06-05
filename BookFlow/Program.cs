
using BookFlow.Infrastructure;
using Microsoft.EntityFrameworkCore;
using SilkRoad.Services;

namespace BookFlow
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });
            builder.Services.AddDbContext<BookFlowContext>(con =>
                con
                    .UseSqlServer(builder.Configuration["ConnectionString"])
                    .LogTo(Console.Write, LogLevel.Information)
                    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

            builder.Services.AddLogging();
            builder.Services.AddControllers();
            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.AddMyServices();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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
