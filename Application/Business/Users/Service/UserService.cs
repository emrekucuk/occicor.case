using Application.Business.Users.DataAccess;
using Application.Business.Users.Interfaces;
using Application.RequestHandler.Users.Queries.All;

namespace Application.Business.Users.Service;

/// <summary>
/// UserService
/// </summary>
public class UserService : IUserService
{
    private readonly UserDataAccess _dataAccessLayer;
    public UserService(UserDataAccess dataAccessLayer)
    {
        _dataAccessLayer = dataAccessLayer;
    }

    // Queries

    /// <summary>
    /// GetAllTags
    /// </summary>
    /// <returns></returns>
    public async Task<List<GetUsersResponse>> GetAllUsers()
    {
        System.Console.WriteLine("part2");

        var users = await _dataAccessLayer.GetAllUsers();
        if (users == null || users.Count == 0)
            return null;

        var mapper = new AllMapper();
        var response = mapper.MapToResponse(users);
        return response;
    }
}