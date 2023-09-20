using Application.UnitOfWork;
using AspNetCoreRateLimit;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace Api.Extensions;
public static class ServicesExtensions{
    public static void AddApplicationServices(this IServiceCollection services){        
        services.AddScoped<IPasswordHasher<User>,PasswordHasher<User>>();        
        services.AddScoped<IUnitOfWork,UnitOfWork>();
    }

    public static void ConfigureCors(this IServiceCollection services){
        services.AddCors(opt =>{
            opt.AddPolicy("CorsPolicy", policy =>{
                policy
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });
    }

    public static void ConfigurationRatelimiting(this IServiceCollection services){
        services.AddMemoryCache();
        services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
        services.AddInMemoryRateLimiting();
        services.Configure<IpRateLimitOptions>(opt =>{
            opt.EnableEndpointRateLimiting = true;
            opt.StackBlockedRequests = false;
            opt.HttpStatusCode = 429;
            opt.RealIpHeader = "X-Real-IP";
            opt.GeneralRules = new(){
                new(){
                   Endpoint = "*",
                   Period = "10s",
                   Limit = 2
                }
            };
        });
    }

    public static void ConfigureApiVersioning(this IServiceCollection services){
        services.AddApiVersioning(opt =>{
            opt.DefaultApiVersion = new(1,0);
            opt.AssumeDefaultVersionWhenUnspecified = true;
            opt.ApiVersionReader = ApiVersionReader.Combine(
                new QueryStringApiVersionReader("ver"),
                new HeaderApiVersionReader("X-Version")
            );
            opt.ReportApiVersions = true;
        });
    }    
}