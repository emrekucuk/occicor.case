using Application.RequestHandler.Tags.Queries.Detail;
using AutoMapper;
using Domain.Entities;

namespace Application.Business.Tags.Mapping;

public class TagMapping : Profile
{
    public TagMapping()
    {
        CreateMap<Tag, GetTagResponse>();
    }
}