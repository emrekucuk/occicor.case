using Domain.Base;

namespace Domain.Entities;

public class User : CoreEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    // Child Object
    public List<RelUserTag> RelUserTags { get; set; }
}
