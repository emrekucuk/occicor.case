using Application.Business.Tags.Interfaces;
using Application.RequestHandler.Tags.Commands.Create;
using Application.RequestHandler.Tags.Commands.Delete;
using Application.RequestHandler.Tags.Commands.Update;
using Application.RequestHandler.Tags.Queries.All;
using Application.RequestHandler.Tags.Queries.Detail;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TagsController : ControllerBase
{
    private readonly ITagService _tagService;

    public TagsController(ITagService tagService)
    {
        _tagService = tagService;
    }

    // Commands

    [HttpPost("[action]")]
    public async Task<ActionResult<CreateTagResponse>> Create([FromBody] CreateTagRequestQuery request)
    {
        var result = await _tagService.CreateTag(request);
        return Ok(result);
    }

    [HttpPut("[action]")]
    public async Task<ActionResult<UpdateTagResponse>> Update([FromBody] UpdateTagRequestQuery request)
    {
        var result = await _tagService.UpdateTag(request);
        return Ok(result);
    }

    [HttpDelete("[action]")]
    public async Task<ActionResult<DeleteTagResponse>> Delete([FromBody] DeleteTagRequestQuery request)
    {
        var result = await _tagService.DeleteTag(request);
        return Ok(result);
    }


    // QUERIES

    /// <summary>
    /// Get Tag Detail
    /// </summary>
    /// <response code="200">Returns Tag Detail in Response.Payload</response>
    [HttpPost("[action]")]
    public async Task<ActionResult<GetTagResponse>> Detail([FromBody] GetTagRequestQuery request)
    {
        var result = await _tagService.GetTagById(request.Id);
        return Ok(result);
    }

    /// <summary>
    /// Get All Tags
    /// </summary>
    /// <response code="200">Returns All Tags in Response.Payload</response>
    [HttpPost("[action]")]
    public async Task<ActionResult<List<GetTagsResponse>>> All([FromBody] GetTagsRequestQuery request)
    {
        var result = await _tagService.GetAllTags();
        return Ok(result);
    }
}