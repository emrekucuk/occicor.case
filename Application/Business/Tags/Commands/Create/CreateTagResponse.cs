using MediatR;

namespace Application.RequestHandler.Tags.Commands.Create;

public class CreateTagResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
