using Microsoft.EntityFrameworkCore;

namespace TEFCore;

public class MockDbContext<T> : IDisposable
    where T : DbContext
{
    private T _context;
    private bool _disposed;

    public T DbContext => _context;

    internal MockDbContext(T dbContext)
    {
       _context = dbContext;
    }

    public virtual void SeedDataBase(Action<T> seedAction)
    {
        seedAction(_context);
        _context.SaveChanges();
    }

    public virtual async Task SeedDataBaseAsync(Func<T, Task> seedActionAsync)
    {
        await seedActionAsync(_context);
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }

        if (disposing)
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        _disposed = true;
    }
}

public static class InMemoryDbContext
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