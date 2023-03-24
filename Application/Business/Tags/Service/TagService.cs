using Application.Business.Tags.Interfaces;
using Application.Business.Tags.DataAccess;
using Application.RequestHandler.Tags.Queries.Detail;
using AutoMapper;
using Application.RequestHandler.Tags.Queries.All;
using Application.RequestHandler.Tags.Commands.Create;
using Application.RequestHandler.Tags.Commands.Update;
using Application.RequestHandler.Tags.Commands.Delete;
using Application.RequestHandler.Tags.Commands.UserTag;

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
    /// CreateTag
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

    /// <summary>
    /// UpdateTag
    /// </summary>
    /// <returns></returns>
    public async Task<UpdateTagResponse> UpdateTag(UpdateTagRequestQuery request)
    {
        var oldEntity = await _dataAccessLayer.GetTagById(request.Id);
        if (oldEntity == null)
            return null;

        var mapper = new UpdateMapper();

        var newEntity = mapper.MapToNewEntity(request);

        // Set Properties
        oldEntity.Name = newEntity.Name;

        await _dataAccessLayer.UpdateTag(oldEntity);

        var response = mapper.MapToResponse(oldEntity);

        return response;
    }

    /// <summary>
    /// DeleteTag
    /// </summary>
    /// <returns></returns>
    public async Task<DeleteTagResponse> DeleteTag(DeleteTagRequestQuery request)
    {
        var tag = await _dataAccessLayer.GetTagById(request.Id);
        if (tag == null)
            return null;

        await _dataAccessLayer.DeleteTag(tag);

        var mapper = new DeleteMapper();

        var response = mapper.MapToResponse(tag);

        return response;
    }

    /// <summary>
    /// CreateUserTag
    /// </summary>
    /// <returns></returns>
    public async Task<UserTagResponse> UserTag(UserTagRequestQuery request)
    {
        var oldRelUserTags = await _dataAccessLayer.GetRelUserTagsByUserId(request.UserId);
        if (oldRelUserTags == null || oldRelUserTags.Count == 0)
            return null;

        var mapper = new UserTagMapper();

        _dataAccessLayer.RemoveRangeRelUserTags(oldRelUserTags);

        // Map to RellTitleCourseUser and Add to Db
        var relUserTags = mapper.MapToNewRelUserTags(request.TagIds, request.UserId);
        if (relUserTags != null && relUserTags.Count > 0)
            _dataAccessLayer.AddRelUserTag(relUserTags);

        // SaveChange to Db
        await _dataAccessLayer.SaveEverything();

        var response = mapper.MapToResponse(relUserTags[0].UserId);

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