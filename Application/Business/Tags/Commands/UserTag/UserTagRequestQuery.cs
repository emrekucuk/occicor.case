using MediatR;

namespace Application.RequestHandler.Tags.Commands.UserTag;

public class UserTagRequestQuery : IRequest<UserTagResponse>
{
    public Guid UserId { get; set; }
    public List<Guid> TagIds { get; set; }
}