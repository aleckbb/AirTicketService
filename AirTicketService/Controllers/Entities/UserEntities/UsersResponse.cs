using AirTicketBL.Users.Entity;

namespace AirTicketService.Controllers.Entities.UserEntities;

public class UsersResponse
{
    public List<UserModel> Users { get; set; }
}