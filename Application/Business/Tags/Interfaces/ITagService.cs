using Application.RequestHandler.Tags.Commands.Create;
using Application.RequestHandler.Tags.Queries.All;
using Application.RequestHandler.Tags.Queries.Detail;

namespace Application.Business.Tags.Interfaces;

public interface ITagService
{
    /// <summary>
    /// Get tag detail by id.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<GetTagResponse> GetTagById(Guid id);

    /// <summary>
    /// Get all tags.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<List<GetTagsResponse>> GetAllTags();

    Task<CreateTagResponse> CreateTag(CreateTagRequestQuery request);
}