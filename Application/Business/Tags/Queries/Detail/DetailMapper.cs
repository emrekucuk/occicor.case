using Domain.Entities;

namespace Application.RequestHandler.Tags.Queries.Detail;

public class DetailMapper
{
    public GetTagResponse MapToResponse(Tag tag)
    {
        return new GetTagResponse()
        {
            Id = tag.Id,
            Name = tag.Name
        };
    }
}