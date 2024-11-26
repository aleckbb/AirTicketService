using AirTicketBL.Authorization.Entities;
using AirTicketBL.Users.Entity;

namespace AirTicketBL.Authorization;

public interface IAuthProvider
{
    Task<UserModel> RegisterUser(string email, string password);
    Task<TokensResponse> AuthorizeUser(string email, string password);
}