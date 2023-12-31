using Microsoft.EntityFrameworkCore;
using BCDatos.DataContext;
using BCDatos.Repositories;
using BCModels.DataContext;
using BCNegocio.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<KACTUSContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("conexion"));
});

builder.Services.AddScoped<IGenericRepository<Cliente>, ClienteRepository>();
builder.Services.AddScoped<IClienteService,ClienteService>();
builder.Services.AddScoped<IGenericRepository<Producto>, ProductoRepository>();
builder.Services.AddScoped<IProductoService,ProductoService>();
builder.Services.AddScoped<IGenericRepository<CabezaFactura>, CabezaFacturaRepository>();
builder.Services.AddScoped<ICabezaFacturaService, CabezaFacturaService>();
builder.Services.AddScoped<IGenericRepository<DetalleFactura>, DetalleFacturaRepository>();
builder.Services.AddScoped<IDetalleFacturaService, DetalleFacturaService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
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
