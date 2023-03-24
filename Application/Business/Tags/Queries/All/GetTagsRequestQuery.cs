using MediatR;

namespace Application.RequestHandler.Tags.Queries.All;

public class GetTagsRequestQuery : IRequest<List<GetTagsResponse>>
{
}