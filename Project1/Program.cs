using Project1;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

//CreateWebHostBuilder(args).Build().Run();

//var host = CreateHostBuilder(args).Build();

//CreateDbIfNotExists(host);

//host.Run();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
}

app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;



app.Run();

GenerateRandomData(100);

static void GenerateRandomData(int numberOfRecords)
{
    ApplicationDbContext context;

    Random _random = new();

    for (int i = 0; i < numberOfRecords; i++)
    {
        // Generate random age between 0 and 120
        int age = _random.Next(0, 121);

        // Generate random gender (30% female, 70% male)
        var gender = _random.Next(1, 101) <= 30 ? Gender.FeMale : Gender.Male;

        // Generate random LastSeenTime within the last 10 days
        DateTime lastSeenTime = DateTime.Now.AddDays(-_random.Next(1, 11));

        // Create Person object
        var person = new Person
        {
            Age = age,
            Gender = gender,
            LastSeenTime = lastSeenTime
        };

        // Add Person object to repository
        //_personRepository.Add(person);
    }
}

static IWebHostBuilder CreateWebHostBuilder(string[] args) { 
       return WebHost.CreateDefaultBuilder(args)
           .UseStartup<Program>()
           .UseKestrel(opt => {
               var sp = opt.ApplicationServices;
               using (var scope = sp.CreateScope())
               {
                   var dbContext = scope.ServiceProvider.GetService<ApplicationDbContext>();
                   var e = dbContext.Persons.FirstOrDefault();
                   // now you get the certificates
               }
           });
 }


static IHostBuilder CreateHostBuilder(string[] args) =>
          Host.CreateDefaultBuilder(args)
              .ConfigureWebHostDefaults(webBuilder =>
              {
                  //webBuilder.UseStartup<Startup>();
              });


static void CreateDbIfNotExists(IHost host)
{
    using (var scope = host.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        try
        {
            var context = services.GetRequiredService<ApplicationDbContext>();
            var e = context.Persons.FirstOrDefault();
            //DbInitializer.Initialize(context);
        }
        catch (Exception ex)
        {
            var logger = services.GetRequiredService<ILogger<Program>>();
            logger.LogError(ex, "An error occurred creating the DB.");
        }
    }
}
