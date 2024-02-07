using Onion.WebApi.LibConfigure;
using OnionArcProject.Infrastruct.Data.DBContext;
using OnionArcProject.Infrastruct.Data.Repositories;
using OnionArcProject.Infrastruct.Services;
using OnionArcProject.Interfaces.RepositoryInterfaces;
using OnionArcProject.Interfaces.ServiceInterfaces;

namespace Onion.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
           
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAutoMapper(cfg => cfg.AddProfile<MapperProfile>());
            builder.Services.AddDbContext<SimpleTestDbContext>();
            builder.Services.AddTransient<IServiceZatichka1, ServiceZatichka1>();
            builder.Services.AddTransient<IVenderRepository, VenderRepository>();
            builder.Services.AddTransient<IGpuRepository, GpuRepository>();

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
