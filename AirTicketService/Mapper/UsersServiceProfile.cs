using AirTicketBL.Users.Entity;
using AirTicketService.Controllers.Entities.UserEntities;
using AutoMapper;

namespace AirTicketService.Mapper;

public class UsersServiceProfile : Profile
{
    public UsersServiceProfile()
    {
        CreateMap<UserFilter, UserFilterModel>();
        CreateMap<RegisterUserRequest, CreateUserModel>();
    }
}