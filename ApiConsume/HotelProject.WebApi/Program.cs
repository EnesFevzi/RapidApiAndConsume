using HotelProject.DataAccessLayer.Concrete;
using HotelProject.BusinessLayer.Extensions;
using HotelProject.DataAccessLayer.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TContext>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.LoadDataLayerExtension();
builder.Services.LoadServiceLayerExtension();


builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddSession();
//builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
