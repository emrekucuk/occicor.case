using MediatR;

namespace Application.RequestHandler.Users.Queries.All;

public class GetUsersRequestQuery : IRequest<List<GetUsersResponse>>
{
}