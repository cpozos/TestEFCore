using Microsoft.EntityFrameworkCore;

namespace TestExample;


public class TestPerson
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}

public class TestDbContext : DbContext
{
    public DbSet<TestPerson> People { get; set; }
    public TestDbContext(DbContextOptions<TestDbContext> options)
        : base(options)
    {
    }

    public TestDbContext()
    {
    }
}
