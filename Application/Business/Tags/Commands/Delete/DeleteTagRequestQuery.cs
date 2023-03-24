using MediatR;

namespace Application.RequestHandler.Tags.Commands.Delete;

public class DeleteTagRequestQuery : IRequest<DeleteTagResponse>
{
    public Guid Id { get; set; }
}