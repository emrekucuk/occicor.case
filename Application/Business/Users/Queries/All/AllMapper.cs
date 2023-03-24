using Domain.Entities;

namespace Application.RequestHandler.Users.Queries.All;

public class AllMapper
{
    public List<GetUsersResponse> MapToResponse(List<User> users)
    {
        return users?.Select((user) =>
            new GetUsersResponse()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
            }
        ).ToList();
    }
}