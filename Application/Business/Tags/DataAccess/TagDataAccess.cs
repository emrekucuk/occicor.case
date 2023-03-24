using Domain.Entities;
using Infrastructure.RelationalDB;
using Microsoft.EntityFrameworkCore;

namespace Application.Business.Tags.DataAccess;

public class TagDataAccess
{
    private readonly ApplicationDbContext _dbContext;
    public TagDataAccess(ApplicationDbContext applicationDbContext)
    {
        _dbContext = applicationDbContext;
    }

    public async Task<Tag> GetTagById(Guid id)
    {
        return await _dbContext.Tags
            .FirstOrDefaultAsync(t => t.Id == id);
    }

    public async Task<List<Tag>> GetAllTags()
    {
        return await _dbContext.Tags.ToListAsync();
    }

    public async Task CreateTag(Tag tag)
    {
        _dbContext.Tags.Add(tag);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateTag(Tag tag)
    {
        _dbContext.Tags.Update(tag);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteTag(Tag tag)
    {
        _dbContext.Tags.Remove(tag);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<RelUserTag>> GetRelUserTagsByUserId(Guid userId)
    {
        return await _dbContext.RelUserTags.Where(r => r.UserId == userId).ToListAsync();
    }


    public void RemoveRangeRelUserTags(List<RelUserTag> relUserTags)
    {
        _dbContext.RelUserTags.RemoveRange(relUserTags);
    }


    public void AddRelUserTag(List<RelUserTag> relUserTags)
    {
        _dbContext.RelUserTags.AddRange(relUserTags);
    }


    public async Task SaveEverything()
    {
        await _dbContext.SaveChangesAsync();
    }

}