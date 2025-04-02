using LMS.BL.Managers.Services;
using LMS.DAL;
using LMS.DAL.Repos.Services;
using Microsoft.Extensions.DependencyInjection;
namespace LMS.BL;

public static class ServicesRegistration
{
    public static void AddDataAccessLayer(this IServiceCollection services)
    {
        services.Scan(scan => scan
            .FromAssemblyOf<BookRepository>()
            .AddClasses(classes => classes.Where(c => c.Name.EndsWith("Repository")))
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        services.Scan(scan => scan
           .FromAssemblyOf<AuthorRepository>()
           .AddClasses(classes => classes.Where(c => c.Name.EndsWith("Repository")))
           .AsImplementedInterfaces()
           .WithScopedLifetime());
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }

    public static void AddBusinessLayer(this IServiceCollection services)
    {
        services.Scan(scan => scan
            .FromAssemblyOf<BookService>()
            .AddClasses(classes => classes.Where(c => c.Name.EndsWith("Service")))
            .AsImplementedInterfaces()
            .WithScopedLifetime());

        services.Scan(scan => scan
         .FromAssemblyOf<AuthorService>()
         .AddClasses(classes => classes.Where(c => c.Name.EndsWith("Service")))
         .AsImplementedInterfaces()
         .WithScopedLifetime());
    }
}
