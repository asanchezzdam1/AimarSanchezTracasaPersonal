using CourseLibrary.API;

var builder = WebApplication.CreateBuilder(args);
  
var app = builder
       // 1- Configurar Servicios
       .ConfigureServices()
       // 2-Configurar Middleware (Peticiones)
       .ConfigurePipeline();

// for demo purposes, delete the database & migrate on startup so 
// we can start with a clean slate
await app.ResetDatabaseAsync();

// run the app
app.Run();
