using Application.Business.Tags.Interfaces;
using Application.Business.Tags.DataAccess;
using Application.RequestHandler.Tags.Queries.Detail;
using AutoMapper;
using Application.RequestHandler.Tags.Queries.All;
using Application.RequestHandler.Tags.Commands.Create;
using Domain.Entities;

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

    // Commands

    /// <summary>
    /// GetTagById
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<CreateTagResponse> CreateTag(CreateTagRequestQuery request)
    {
        if (request.Name == null)
            return null;

        var mapper = new CreateMapper();

        var tag = mapper.MapToNewEntity(request);

        await _dataAccessLayer.CreateTag(tag);


        var response = mapper.MapToResponse(tag);

        return response;
    }

    // Queries

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

    /// <summary>
    /// GetAllTags
    /// </summary>
    /// <returns></returns>
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