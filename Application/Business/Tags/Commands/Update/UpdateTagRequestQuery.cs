using MediatR;

namespace Application.RequestHandler.Tags.Commands.Update;

public class UpdateTagRequestQuery : IRequest<UpdateTagResponse>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}