using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Rozklad.Core;
using Rozklad.Infrastructure;
using Rozklad.Repository;
using Rozklad.Repository.Repositories;
using RozkladAppBlazor.Server.Data;
using System.Globalization;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(AppAutoMapper).Assembly);
builder.Services.AddSingleton<WeatherForecastService>();
var connectionString = builder.Configuration.GetConnectionString("RozkladSchoolConnection");
builder.Services.AddDbContext<RozkladContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    // Define the list of cultures your app will support 
    var supportedCultures = new List<CultureInfo>()
                {
                    new CultureInfo("uk-UA")
                };

    // Set the default culture 
    options.DefaultRequestCulture = new RequestCulture("uk-UA");
    options.DefaultRequestCulture.Culture.NumberFormat.CurrencySymbol = supportedCultures[1].NumberFormat.CurrencySymbol;

    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
    options.RequestCultureProviders = new List<IRequestCultureProvider>() {
                 new QueryStringRequestCultureProvider()
                };
});

builder.Services.AddScoped<TimetableRepository>();
builder.Services.AddScoped<CabinetRepository>();
builder.Services.AddScoped<TeacherRepository>();
builder.Services.AddScoped<LessonRepository>();
builder.Services.AddScoped<PupilRepository>();
builder.Services.AddScoped<ClassRoomRepository>();
builder.Services.AddScoped<DisciplineRepository>();
//builder.Services.AddScoped<UsersRepository>();
builder.Services.AddScoped<WeekRepository>();
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {

        Version = "v1",
        Title = "Adding an API to our Schedule project",
        Description = "Education project with KN3, Ostroh Academy",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Email = "pavlo.koshubinskyi@oa.edu.ua",
            Name = "Pavlo Koshubinskyi"
        }

    });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";//через іксемель коментарі документується код
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    //options.IncludeXmlComments(xmlPath);
});

builder.Services.AddRouting(options => options.LowercaseUrls = true);

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
