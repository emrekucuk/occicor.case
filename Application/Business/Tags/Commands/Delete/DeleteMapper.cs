using Domain.Entities;

namespace Application.RequestHandler.Tags.Commands.Delete;

public class DeleteMapper
{

    public DeleteTagResponse MapToResponse(Tag tag)
    {
        return new DeleteTagResponse()
        {
            Id = tag.Id,
            Name = tag.Name
        };
    }
}