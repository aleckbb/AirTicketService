﻿using AirTicketBL.Mapper;
using AirTicketService.Mapper;

namespace AirTicketService.IoC;

public class MapperConfigurator
{
    public static void ConfigureServices(WebApplicationBuilder builder)
    {
        var services = builder.Services;
        services.AddAutoMapper(config =>
        {
            config.AddProfile<UsersBLProfile>();
            config.AddProfile<UsersServiceProfile>();
        });
    }
}