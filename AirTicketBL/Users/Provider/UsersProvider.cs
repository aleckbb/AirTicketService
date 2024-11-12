using AirTicketBL.Users.Entity;
using AirTicketBL.Users.Exceptions;
using AirTicketDataAccess.entities;
using AirTicketDataAccess.Repository;
using AutoMapper;

namespace AirTicketBL.Provider;

public class UsersProvider : IUsersProvider
{
    private readonly IRepository<UserEntity> _userRepository;
    private readonly IMapper _mapper;

    public UsersProvider(IRepository<UserEntity> userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public IEnumerable<UserModel> GetUsers(UserFilterModel filter = null)
    {
        string? namePart = filter?.NamePart;
        string? emailPart = filter?.EmailPart;
        DateTime? creationTime = filter?.CreationTime;
        DateTime? modificationTime = filter?.ModificationTime;
        int? role = filter?.Role;

        var users = _userRepository.GetAll(u =>
            (namePart == null || u.UserName.Contains(namePart)) &&
            (emailPart == null || u.Email.Contains(emailPart)) &&
            (creationTime == null || u.CreationTime == creationTime) &&
            (modificationTime == null || u.ModificationTime == modificationTime) &&
            (role == null || u.Role.Id == role)
        );
        return _mapper.Map<IEnumerable<UserModel>>(users);
    }

    public UserModel GerUserInfo(int id)
    {
        var entity = _userRepository.GetById(id);
        if (entity == null)
        {
            throw new UserNotFoundException("User not found");
        }

        return _mapper.Map<UserModel>(entity);
    }
}