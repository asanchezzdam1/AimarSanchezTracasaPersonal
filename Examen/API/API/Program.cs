using Context;
using Microsoft.EntityFrameworkCore;
using Modelos;
using Newtonsoft.Json.Serialization;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //++1
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers(configure => { configure.ReturnHttpNotAcceptable = true; })
                            .AddNewtonsoftJson(setupAction =>
                            {
                                setupAction.SerializerSettings.ContractResolver =
                                    new CamelCasePropertyNamesContractResolver();
                            });
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddScoped<IRepositorioUsuarios, RepositorioUsuarios>();
            builder.Services.AddDbContext<ContextoConversor>(options =>
            {
                options.UseSqlServer(builder.Configuration["ConnectionStrings:ConexionDatos"]);
            });
            builder.Services.AddCors(options =>
            {
                options
                            .AddPolicy("AllowAll", builder =>
                            {
                                builder
                                     .AllowAnyOrigin()
                                     .AllowAnyMethod()
                                     .AllowAnyHeader();
                            });
            });
            //++2
            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors("AllowAll");
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
                        {
                            endpoints.MapControllers();
                        });
            app.MapControllers();
            app.Run();
        }
    }
}