using Domain.Entities;
using Infrastructure.RelationalDB;
using Microsoft.EntityFrameworkCore;

namespace Application.Business.Users.DataAccess;

public class UserDataAccess
{
    private readonly ApplicationDbContext _dbContext;
    public UserDataAccess(ApplicationDbContext applicationDbContext)
    {
        _dbContext = applicationDbContext;
    }

    public async Task<List<User>> GetAllUsers()
    {
        return await _dbContext.Users.ToListAsync();
    }

}