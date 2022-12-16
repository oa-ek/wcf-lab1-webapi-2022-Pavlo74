using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Rozklad.Core;
using Rozklad.Infrastructure;
using Rozklad.Repository.Repositories;
using System.Globalization;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("RozkladSchoolConnection");
builder.Services.AddDbContext<RozkladContext>(options =>
    options.UseSqlServer(connectionString));
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();



builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

//builder.Services.AddControllersWithViews();
//builder.Services.AddTransient<UsersRepository>();
//builder.Services.AddTransient<ClassRoomRepository>();
//builder.Services.AddTransient<LessonRepository>();
//builder.Services.AddTransient<CabinetRepository>();
//builder.Services.AddScoped<CabinetAPIRepository>();
builder.Services.AddScoped<TimetableRepository>();
//builder.Services.AddScoped<LessonAPIRepository>();
//builder.Services.AddScoped<UsersAPIRepository>();
//builder.Services.AddTransient<TeacherRepository>();
//builder.Services.AddTransient<DisciplineRepository>();
//builder.Services.AddTransient<PupilRepository>();

//builder.Services.AddTransient<TimetableRepository>();

builder.Services.AddAutoMapper(typeof(AppAutoMapper).Assembly);

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

/*builder.Services.Configure<RequestLocalizationOptions>(options =>
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
});*/



builder.Services.AddRouting(options => options.LowercaseUrls = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
    app.UseWebAssemblyDebugging();
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
