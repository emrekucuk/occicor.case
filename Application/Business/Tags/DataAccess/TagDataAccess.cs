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

}