using Microsoft.EntityFrameworkCore;
using SuperHeroAPI_DotNet8.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// dependency injection
builder.Services.AddDbContext<DataContext>(options =>
{
    // UseSqlServer right click on projectname DotNet8 then Manage NuGet Packages and add Microsoft.EntityFrameworkCore.SqlServer
    options.UseSqlServer(connectionString: builder.Configuration.GetConnectionString("DefaultConnection")); // from appsettings.json
});  // needed for migration from NuGet Packages and add Microsoft.EntityFrameworkCore.Tools
     // you can Use the CLI or this method
     // then from Tools bar => NuGet Packages Manager => Package Manager Console
     // Add-Migration Initial
     // Update-DataBase   -> will not work yet since Only the invariant culture is supported in globalization-invariant mode -> from the project file make it False


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//MW Middlewares
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
