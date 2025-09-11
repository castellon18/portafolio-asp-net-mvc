using Portafolio.Interfaces;
using Portafolio.Repositorios;
using Portafolio.Servicios;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Inyectando Repositorios
builder.Services.AddTransient<IProyectoRepositorio, ProyectoRepositorio>();
builder.Services.AddTransient<IFormacionAcademicaRepositorio, FormacionAcademicaRepositorio>();
builder.Services.AddTransient<IHabilidadRepositorio, HabilidadRepositorio>();
builder.Services.AddTransient<IExperienciaLaboralRepositorio, ExperienciaLaboralRepositorio>();

//Inyectando Servicio
builder.Services.AddTransient<IEmailServicio, EmailGmailServicio>();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}").WithStaticAssets();

app.Run();
