global using AutoMapper;
global using MenuPlanner.Components.Account.Pages;
global using MenuPlanner.Components.Account.Pages.Manage;
global using MenuPlanner.Data;
global using MenuPlanner.Enums;
global using MenuPlanner.Models.AutoMapperProfiles;
global using MenuPlanner.Models.DTOs.Display;
global using MenuPlanner.Models.DTOs.Manage;
global using MenuPlanner.Models.Entities;
global using MenuPlanner.Services.AllergenService;
global using MenuPlanner.Services.CountryService;
global using MenuPlanner.Services.IngredientService;
global using MenuPlanner.Services.NutrientService;
global using MenuPlanner.Services.RecipeService;
global using MenuPlanner.Services.SearchService;
global using MenuPlanner.Services.UserService;
global using Microsoft.AspNetCore.Authentication;
global using Microsoft.AspNetCore.Components.Authorization;
global using Microsoft.AspNetCore.Http.Extensions;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Primitives;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
global using System.Security.Claims;
global using System.Text.Json;
using MenuPlanner.Components;
using MenuPlanner.Components.Account;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

// Connection string navn:
string productionDb = "DefaultConnection";
string unitTestDb = "TestDBConnection";

string connStrName = productionDb;

var connectionString = builder.Configuration.GetConnectionString(connStrName)
        ?? throw new InvalidOperationException($"Connection string '{connStrName}' not found.");

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(connectionString);
    options.EnableSensitiveDataLogging(); // Fjern denne for production
});


builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DataContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<User>, IdentityNoOpEmailSender>();

builder.Services.AddAutoMapper(typeof(IngredientProfile));

builder.Services.AddScoped<IIngredientService, IngredientService>();
builder.Services.AddScoped<INutrientService, NutrientService>();
builder.Services.AddScoped<IAllergenService, AllergenService>();
builder.Services.AddScoped<IRecipeService, RecipeService>();
builder.Services.AddScoped<ISearchService, SearchService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ICountryService, CountryService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();