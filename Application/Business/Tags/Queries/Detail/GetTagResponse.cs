using MediatR;

namespace Application.RequestHandler.Tags.Queries.Detail;

public class GetTagResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
