global using AutoMapper;
global using MenuPlanner.Components;
global using MenuPlanner.Components.Shared.Account;
global using MenuPlanner.Components.Shared.Account.Pages;
global using MenuPlanner.Components.Shared.Account.Pages.Manage;
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
global using Microsoft.AspNetCore.Authentication.Google;
global using Microsoft.AspNetCore.Components;
global using Microsoft.AspNetCore.Components.Authorization;
global using Microsoft.AspNetCore.Components.Server;
global using Microsoft.AspNetCore.Http.Extensions;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Options;
global using Microsoft.Extensions.Primitives;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
global using System.Diagnostics.CodeAnalysis;
global using System.Security.Claims;
global using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services
    .AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddGoogle(googleOptions =>
    {
        googleOptions.ClientId = config["Authentication:Google:ClientId"];
        googleOptions.ClientSecret = config["Authentication:Google:ClientSecret"];
    })
    .AddIdentityCookies();

// ConnectionString-name:
Connection connStrName = Connection.DefaultDb; // Production or test-database?

var connectionString = config.GetConnectionString(connStrName.ToString())
        ?? throw new InvalidOperationException($"Connection string '{connStrName.ToString()}' not found.");

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(connectionString);
    options.EnableSensitiveDataLogging(); // Remove this when in production
});


builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DataContext>()
    //.AddRoles<IdentityRole>()
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
