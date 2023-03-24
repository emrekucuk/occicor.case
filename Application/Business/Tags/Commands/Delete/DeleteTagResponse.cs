using MediatR;

namespace Application.RequestHandler.Tags.Commands.Delete;

public class DeleteTagResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
