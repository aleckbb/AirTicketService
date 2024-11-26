using AirTicketBL.Authorization;
using AirTicketBL.Provider;
using AirTicketBL.Users.Manager;
using AirTicketDataAccess;
using AirTicketDataAccess.entities;
using AirTicketDataAccess.Repository;
using AirTicketService.Settings;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AirTicketService.IoC;

public static class ServicesConfigurator
{
    public static void ConfigureServices(IServiceCollection services, AirTicketSettings settings)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IRepository<UserEntity>>(x => 
            new Repository<UserEntity>(x.GetRequiredService<IDbContextFactory<AirTicketDbContext>>()));
        services.AddScoped<IUsersProvider>(x => 
            new UsersProvider(x.GetRequiredService<IRepository<UserEntity>>(), 
                x.GetRequiredService<IMapper>()));
        services.AddScoped<IUsersManager>(x =>
            new UsersManager(x.GetRequiredService<IRepository<UserEntity>>(),
                x.GetRequiredService<IMapper>()));
        
        services.AddScoped<IAuthProvider>(x =>
            new AuthProvider(x.GetRequiredService<SignInManager<UserEntity>>(),
                x.GetRequiredService<UserManager<UserEntity>>(),
                x.GetRequiredService<IHttpClientFactory>(),
                settings.IdentityServerUri!,
                settings.ClientId!,
                settings.ClientSecret!,
                x.GetRequiredService<IMapper>()
            ));
    }
}