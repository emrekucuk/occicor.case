using Domain.Base;

namespace Domain.Entities;

public class Tag : CoreEntity
{
    public string Name { get; set; }

    // Child Objects
    public List<RelUserTag> RelUserTags { get; set; }
}