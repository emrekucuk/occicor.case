using Domain.Entities;

namespace Application.RequestHandler.Tags.Commands.Update;

public class UpdateMapper
{
    public Tag MapToNewEntity(UpdateTagRequestQuery request)
    {
        return new Tag()
        {
            Name = request.Name
        };
    }

    public UpdateTagResponse MapToResponse(Tag tag)
    {
        return new UpdateTagResponse()
        {
            Id = tag.Id,
            Name = tag.Name
        };
    }
}