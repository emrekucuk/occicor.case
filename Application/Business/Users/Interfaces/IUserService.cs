using Application.RequestHandler.Users.Queries.All;

namespace Application.Business.Users.Interfaces;

public interface IUserService
{
    /// <summary>
    /// Get all users.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<List<GetUsersResponse>> GetAllUsers();
}