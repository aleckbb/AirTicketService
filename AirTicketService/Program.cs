using AirTicketService.DI;
using AirTicketService.IoC;

var builder = WebApplication.CreateBuilder(args);

ApplicationConfigurator.ConfigureServices(builder);

var app = builder.Build();

ApplicationConfigurator.ConfigureApplication(app);

app.Run();