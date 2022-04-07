using Domain.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Model.Configuration;
using Model.Entities;
using MudBlazor;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AuroraDbContext>( 
    options => options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"), 
        new MySqlServerVersion(new Version(8,0,27))
    )
);
builder.Services.AddMudServices(config => {
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomLeft;

    config.SnackbarConfiguration.PreventDuplicates = true;
    config.SnackbarConfiguration.NewestOnTop = false;
    config.SnackbarConfiguration.ShowCloseIcon = true;
    config.SnackbarConfiguration.VisibleStateDuration = 10000;
    config.SnackbarConfiguration.HideTransitionDuration = 500;
    config.SnackbarConfiguration.ShowTransitionDuration = 500;
    config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
});
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<IRepository<AConvoyElement>, ConvoyElementRepository>();
builder.Services.AddScoped<IRepository<Addon>, AddonRepository>();
builder.Services.AddScoped<IRepository<AUpgradeable>, UpgradeableRepository>();
builder.Services.AddScoped<IRepository<Convoy>, ConvoyRepository>();
builder.Services.AddScoped<IRepository<Truck>, TruckRepository>();
builder.Services.AddScoped<IRepository<Wagon>, WagonRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
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

// TODO Kohision Innerer Zusammenhang der klasse
// nur methoden die auch was mit der klasse zutun haben, das selbe mit variablen

// Composite pattern, Visitor, Prädikat 

// class mit "global using [USING]"