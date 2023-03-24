using Domain.Base;

namespace Domain.Entities;

public class RelUserTag : CoreEntity
{
    // Parent Objects

    public User User { get; set; }
    public Guid UserId { get; set; }

    public Tag Tag { get; set; }
    public Guid TagId { get; set; }
}