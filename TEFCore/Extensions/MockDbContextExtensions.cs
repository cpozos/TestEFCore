using Microsoft.EntityFrameworkCore;

namespace TEFCore.Extensions;

public static class MockDbContextExtensions
{
    public static MockDbContext<T> Create<T>(Func<DbContextOptions<T>, T> dbContextCreator)
       where T : DbContext
    {
        var builder = new DbContextOptionsBuilder<T>();
        builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
        var options = builder.Options;
        T dbContext = dbContextCreator(options);
        dbContext.Database.EnsureCreated();
        return new MockDbContext<T>(dbContext);
    }

    public static MockDbContext<T> Create<T>(Action<DbContextOptionsBuilder> applyExtraOptionsBuilder = null)
       where T : DbContext
    {
        DbContextOptionsBuilder<T> builder = new();
        builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
        applyExtraOptionsBuilder?.Invoke(builder);

        object[] lobject = new object[] { builder.Options };
        var constructorInfo = typeof(T).GetConstructor(new[] { typeof(DbContextOptions<T>) });
        T? dbContext = constructorInfo?.Invoke(lobject) as T;
        if (dbContext is null)
        {
            throw new NullReferenceException(nameof(dbContext));
        }

        dbContext.Database.EnsureCreated();
        return new MockDbContext<T>(dbContext);
    }
}