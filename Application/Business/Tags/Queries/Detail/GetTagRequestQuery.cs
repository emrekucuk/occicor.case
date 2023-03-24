using MediatR;

namespace Application.RequestHandler.Tags.Queries.Detail;

public class GetTagRequestQuery : IRequest<GetTagResponse>
{
    public Guid Id { get; set; }
}