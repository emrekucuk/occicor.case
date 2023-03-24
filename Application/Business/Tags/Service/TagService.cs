using Application.Business.Tags.Interfaces;
using Application.Business.Tags.DataAccess;
using Application.RequestHandler.Tags.Queries.Detail;
using AutoMapper;
using Application.RequestHandler.Tags.Queries.All;

namespace Application.Business.Tags.Service;

/// <summary>
/// TagService
/// </summary>
public class TagService : ITagService
{
    private readonly TagDataAccess _dataAccessLayer;
    private readonly IMapper _mapper;
    public TagService(TagDataAccess dataAccessLayer, IMapper mapper)
    {
        _dataAccessLayer = dataAccessLayer;
        _mapper = mapper;
    }


    /// <summary>
    /// GetTagById
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<GetTagResponse> GetTagById(Guid id)
    {
        var tag = await _dataAccessLayer.GetTagById(id);
        if (tag == null)
            return null;

        var mapper = new DetailMapper();
        var response = mapper.MapToResponse(tag);

        return response;
    }

    public async Task<List<GetTagsResponse>> GetAllTags()
    {
        var tags = await _dataAccessLayer.GetAllTags();
        if (tags == null || tags.Count == 0)
            return null;

        var mapper = new AllMapper();
        var response = mapper.MapToResponse(tags);
        return response;
    }
}