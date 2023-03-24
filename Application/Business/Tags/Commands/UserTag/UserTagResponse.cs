using MediatR;

namespace Application.RequestHandler.Tags.Commands.UserTag;

public class UserTagResponse
{
    public Guid UserId { get; set; }
}
