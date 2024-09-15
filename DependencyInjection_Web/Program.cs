using ServiceContracts;
using Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
//IoC (Inversion of Control)
// builder.Services.Add(new ServiceDescriptor(
//     typeof(ICitiesService),
//     typeof(CitiesService),
//     ServiceLifetime.Singleton
// ));
//builder.Services.AddTransient<ICitiesService, CitiesService>();
builder.Services.AddScoped<ICitiesService, CitiesService>();
//builder.Services.AddSingleton<ICitiesService, CitiesService>();
var app = builder.Build();



app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
