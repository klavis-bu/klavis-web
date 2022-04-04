using Klavis.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Google.Cloud.Firestore;
using Radzen;
using Microsoft.AspNetCore.Authentication;
using static Microsoft.Extensions.Configuration.IConfiguration;

var builder = WebApplication.CreateBuilder(args);

var AuthClientID = builder.Configuration["Google:ClientID"];
var AuthClientSecret = builder.Configuration["Google:ClientSecret"];
Console.WriteLine(AuthClientID);

IConfiguration Configuration;

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<DialogService>();
builder.Services.AddAuthentication()
   .AddGoogle(googleoptions =>
   {
       //IConfigurationSection googleAuthNSection =
       //config.GetSection("Authentication:Google");
       googleoptions.ClientId = builder.Configuration["Authentication:Google:ClientId"];
       googleoptions.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"];
   });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

