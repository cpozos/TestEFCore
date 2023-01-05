using TEFCore;

namespace TestExample;

public class NoClashingTests
{
    [Fact]
    public void Test1()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test2()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test3()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test4()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test5()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test6()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test7()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test8()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test9()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test10()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test11()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test12()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test13()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test14()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test15()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test16()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test17()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test18()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test19()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test20()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test21()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test22()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test23()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    [Fact]
    public void Test24()
    {
        using var db = Create<TestDbContext>();
        db.SeedDataBase(SeedData);

        var people = db.DbContext.People.ToList();
        people.Should().HaveCount(Seedings.People.Count);
    }

    internal static void SeedData(TestDbContext dbContext)
    {
        dbContext.People.AddRange(Seedings.People);
    }
}

public static class Seedings
{
    public static List<TestPerson> People = new List<TestPerson>
    {
        new TestPerson
        {
            Id = Guid.Parse("1b065bf5-8f21-4cb7-bb80-10ed31d1dbed"),
            Name = "Name"
        },
        new TestPerson
        {
            Id = Guid.Parse("2b065bf5-8f21-4cb7-bb80-10ed31d1dbed"),
            Name = "Name"
        },
        new TestPerson
        {
            Id = Guid.Parse("3b065bf5-8f21-4cb7-bb80-10ed31d1dbed"),
            Name = "Name"
        },
        new TestPerson
        {
            Id = Guid.Parse("4b065bf5-8f21-4cb7-bb80-10ed31d1dbed"),
            Name = "Name"
        },
        new TestPerson
        {
            Id = Guid.Parse("5b065bf5-8f21-4cb7-bb80-10ed31d1dbed"),
            Name = "Name"
        },
        new TestPerson
        {
            Id = Guid.Parse("6b065bf5-8f21-4cb7-bb80-10ed31d1dbed"),
            Name = "Name"
        },
    };
}