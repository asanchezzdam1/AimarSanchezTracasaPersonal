using EjemploMVC.Data;
using EjemploMVC.Models;
using EjemploMVC.Servicios;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EjemploMVC
{
    public class Program
    {
        // 1-Crear interfaz IMail
        // 2-Crear dos clases MailDesarrollo y MailProduccion
        // 3-Configurar el servicio 
        // 4-Agregar interfaz en el constructor
        // 5-Enviar un correo en el momento que va a la pagina Privacy


        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //++ 1-Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            builder.Services.AddControllersWithViews();  // MVC

            builder.Services.AddScoped<IServicioMonedas, ServicioCriptoMonedas>();
            //builder.Services.AddScoped<IMail, MailProduccion>();
            builder.Services.AddScoped<IMail, MailDesarrollo>();



            var app = builder.Build();

            //++ 2-Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}