using CallAPIProject.Data;
using CallAPIProject.Pages.Project.Services;
using CallAPIProject.Pages.Project.TokenService;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<HttpClient>();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddScoped<IJsonPlaceholder, JsonPlaceholderData>();

builder.Services.AddScoped<IGetInventoryData, GetInventoryData>();

builder.Services.AddHttpClient<IJsonPlaceholder, JsonPlaceholderData>(client =>
                        {
                            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
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
