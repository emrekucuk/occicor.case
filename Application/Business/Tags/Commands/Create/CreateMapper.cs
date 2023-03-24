using Domain.Entities;

namespace Application.RequestHandler.Tags.Commands.Create;

public class CreateMapper
{
    public Tag MapToNewEntity(CreateTagRequestQuery request)
    {
        return new Tag()
        {
            Name = request.Name
        };
    }

    public CreateTagResponse MapToResponse(Tag tag)
    {
        return new CreateTagResponse()
        {
            Id = tag.Id,
            Name = tag.Name
        };
    }
}