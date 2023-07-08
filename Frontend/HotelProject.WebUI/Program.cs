
using HotelProject.BusinessLayer.Extensions;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Extensions;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<TContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<TContext>().AddDefaultTokenProviders();
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
builder.Services.AddAuthorization();
builder.Services.LoadDataLayerExtension();
builder.Services.LoadServiceLayerExtension();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddAutoMapper(typeof(Program).Assembly);


//builder.Services.AddMvc(config =>
//{
//	var policy = new AuthorizationPolicyBuilder()
//	.RequireAuthenticatedUser()
//	.Build();
//	config.Filters.Add(new AuthorizeFilter(policy));

//});
//builder.Services.AddAuthentication(
//                CookieAuthenticationDefaults.AuthenticationScheme)
//                .AddCookie(x =>
//                {
//                    x.LoginPath = "/Login/Index";
//                }
//            );

builder.Services.ConfigureApplicationCookie(options =>
{
	options.Cookie.HttpOnly = true;
	options.ExpireTimeSpan = TimeSpan.FromDays(1);
	options.AccessDeniedPath = "/ErrorPage/Index";
	options.LoginPath = "/Login/Index/";
	options.LogoutPath = "/Login/Logout";
	options.SlidingExpiration = true;

});

//builder.Services.AddAuthorization(options =>
//{
//    options.AddPolicy("Admin", policy =>
//    {
//        policy.RequireRole("Admin");
//    });
//});

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
