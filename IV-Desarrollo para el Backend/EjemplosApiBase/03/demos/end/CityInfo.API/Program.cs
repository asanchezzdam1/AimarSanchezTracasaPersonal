using Microsoft.AspNetCore.StaticFiles;

var builder = WebApplication.CreateBuilder(args);

//+ 1-Add services to the container.

builder.Services.AddControllers();  // MVC

// Documentador de la API    
// Learn more about configuring Swagger/OpenAPI at
// https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

//+ 2-Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Prepara la documentacion
    app.UseSwaggerUI(); // Genera la documentación
}



app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
