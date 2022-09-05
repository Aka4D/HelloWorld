using HelloWorld.Data;
using HelloWorld.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Runtime.CompilerServices;
using HelloWorld;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

var localization = new Localization();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<CounterState>();

builder.Services.AddHttpClient(); //Required for REST API

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources"); //Required for Localisation

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

app.UseRequestLocalization(localization.GetLocalizationOptions(configuration)); //Required for Localisation (position in this file is important)

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); //for MVC
});

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
