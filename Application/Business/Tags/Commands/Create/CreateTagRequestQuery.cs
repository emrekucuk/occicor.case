using MediatR;

namespace Application.RequestHandler.Tags.Commands.Create;

public class CreateTagRequestQuery : IRequest<CreateTagResponse>
{
    public string Name { get; set; }
}