using MediatR;

namespace Application.RequestHandler.Tags.Queries.All;

public class GetTagsResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
