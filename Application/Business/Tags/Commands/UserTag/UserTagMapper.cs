using Domain.Entities;

namespace Application.RequestHandler.Tags.Commands.UserTag;

public class UserTagMapper
{
    public UserTagResponse MapToResponse(Guid userId)
    {
        return new UserTagResponse()
        {
            UserId = userId
        };
    }


    public List<RelUserTag> MapToNewRelUserTags(List<Guid> tagIds, Guid userId)
    {
        if (tagIds == null || tagIds.Count == 0)
            return new List<RelUserTag>();

        return tagIds?.Select((tagId) =>
           new RelUserTag()
           {
               UserId = userId,
               TagId = tagId,
           }).ToList() ?? new List<RelUserTag>();
    }
}