using AirTicketBL.Users.Entity;

namespace AirTicketBL.Provider;

public interface IUsersProvider
{
    IEnumerable<UserModel> GetUsers(UserFilterModel filter = null);
    UserModel GerUserInfo(int id);
}