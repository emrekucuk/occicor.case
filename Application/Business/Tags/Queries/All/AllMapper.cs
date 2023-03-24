using Domain.Entities;

namespace Application.RequestHandler.Tags.Queries.All;

public class AllMapper
{
    public List<GetTagsResponse> MapToResponse(List<Tag> tags)
    {
        return tags?.Select((tag) =>
            new GetTagsResponse()
            {
                Id = tag.Id,
                Name = tag.Name,
            }
        ).ToList();
    }
}