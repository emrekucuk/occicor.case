using Application.Business.Users.Interfaces;
using Application.RequestHandler.Users.Queries.All;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService UserService)
    {
        _userService = UserService;
    }


    // QUERIES

    /// <summary>
    /// Get All Users
    /// </summary>
    /// <response code="200">Returns All Users in Response.Payload</response>
    [HttpPost("[action]")]
    public async Task<ActionResult<List<GetUsersResponse>>> All([FromBody] GetUsersRequestQuery request)
    {
        System.Console.WriteLine("part1");
        var result = await _userService.GetAllUsers();
        return Ok(result);
    }
}