using System.Reflection;
using System.Text;
using Api.Extensions;
using AspNetCoreRateLimit;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();



//-Add Authentication
builder.Services.AddAuthentication(x => {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    }).AddJwtBearer(x=>{
        x.TokenValidationParameters =new TokenValidationParameters{
            ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
            ValidAudience = builder.Configuration["JwtSettings:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:Key"]!)),
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true
        };
    });

builder.Services.AddAuthentication();

//-Add Sql Connection
builder.Services.AddDbContext<DataContext>(opts =>{
    string connection = builder.Configuration["ConnectionStrings:ConnectionKaren"]?? throw new Exception("Error: Invalid Connection");
    opts.UseMySql(connection, ServerVersion.AutoDetect(connection));
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add Configurations
builder.Services.AddApplicationServices();
builder.Services.ConfigureCors();
builder.Services.ConfigurationRatelimiting();
builder.Services.ConfigureApiVersioning();
builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using(var scope = app.Services.CreateScope()){
    var services = scope.ServiceProvider;
    var loggerFactory = services.GetRequiredService<ILoggerFactory>();
    try{
        
        var context = services.GetRequiredService<DataContext>();
        await context.Database.MigrateAsync();

    }catch (Exception ex){
        var logger = loggerFactory.CreateLogger<Program>();
        logger.LogError(ex,"Ocurrio un error durante la migracion");
    }
}

app.UseCors("CorsPolicy");
app.UseApiVersioning();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseIpRateLimiting();

app.MapControllers();

app.Run();