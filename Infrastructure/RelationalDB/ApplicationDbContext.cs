using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.RelationalDB;
public class ApplicationDbContext : DbContext
{

    public DbSet<User> Users { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<RelUserTag> RelUserTags { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().HasData(
            new User()
            {
                Id = Guid.Parse("f973d74b-b7df-40a6-a530-017dcdd870e7"),
                FirstName = "John",
                LastName = "Doe",
                Email = "john@hotmail.com",
                Phone = "05451265284"
            },
            new User()
            {
                Id = Guid.Parse("56d1fcf1-1807-4211-9315-43507193444c"),
                FirstName = "Mary",
                LastName = "Doe",
                Email = "john@hotmail.com",
                Phone = "05451265284"
            }
        );

        modelBuilder.Entity<Tag>().HasData(
            new Tag()
            {
                Id = Guid.Parse("7ecbd3c6-ae49-4d9f-a5a9-198b49f8fb30"),
                Name = "Elma",
            },
            new Tag()
            {
                Id = Guid.Parse("4502a8b0-7d98-4516-87ad-0d45c76febb0"),
                Name = "Armut"
            },
            new Tag()
            {
                Id = Guid.Parse("ce0f63de-b59a-4a09-a5fe-4fa52de402ba"),
                Name = "Ayva"
            },
            new Tag()
            {
                Id = Guid.Parse("41766635-e22f-4b71-a1fc-c974b720475e"),
                Name = "Çilek"
            },
            new Tag()
            {
                Id = Guid.Parse("49c305f9-5927-4df4-9b6d-afa0c34771b5"),
                Name = "Muz"
            }
        );

        modelBuilder.Entity<RelUserTag>().HasData(
            new RelUserTag()
            {
                Id = Guid.Parse("6271588b-3f29-4cfc-8c03-0a914c76384b"),
                UserId = Guid.Parse("f973d74b-b7df-40a6-a530-017dcdd870e7"),
                TagId = Guid.Parse("7ecbd3c6-ae49-4d9f-a5a9-198b49f8fb30")
            },
            new RelUserTag()
            {
                Id = Guid.Parse("21893aeb-056e-4e4a-a758-fed2e03cb3e8"),
                UserId = Guid.Parse("f973d74b-b7df-40a6-a530-017dcdd870e7"),
                TagId = Guid.Parse("4502a8b0-7d98-4516-87ad-0d45c76febb0")
            },
            new RelUserTag()
            {
                Id = Guid.Parse("24093bd9-6fe5-4c19-b03e-20d8c54acaa3"),
                UserId = Guid.Parse("56d1fcf1-1807-4211-9315-43507193444c"),
                TagId = Guid.Parse("41766635-e22f-4b71-a1fc-c974b720475e")
            },
            new RelUserTag()
            {
                Id = Guid.Parse("915c5232-f0dd-4c74-b42e-ab3c7fc28877"),
                UserId = Guid.Parse("56d1fcf1-1807-4211-9315-43507193444c"),
                TagId = Guid.Parse("7ecbd3c6-ae49-4d9f-a5a9-198b49f8fb30")
            }
        );
    }
}